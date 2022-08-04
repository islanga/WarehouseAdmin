using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseAdminAPI.Data;
using WarehouseAdminAPI.Models;

namespace WarehouseAdminAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        protected readonly WarehouseDbContext _context;

        public SupplierController(WarehouseDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Suppliers>> Get() => await _context.suppliers.FromSqlRaw("GetAllSuppliers").ToListAsync();

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Suppliers), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id)
        {
            var user = await _context.suppliers.FromSqlRaw($"SearchSupplier {id}").ToListAsync();
            return user == null ? NotFound() : Ok(user);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create(Suppliers supplier)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _context.Database.ExecuteSqlRawAsync("InsertSupplier @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10", parameters: new Object[] {
                supplier.CompanyName,
                supplier.ContactName,
                supplier.ContactTitle,
                supplier.Address,
                supplier.City,
                supplier.Region,
                supplier.PostalCode,
                supplier.Country,
                supplier.Phone,
                supplier.Fax,
                supplier.HomePage
            });

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = supplier.SupplierID }, supplier);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, Suppliers supplier)
        {
            await _context.Database.ExecuteSqlRawAsync("UpdateSupplier @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11", parameters: new Object[] {
                id,
                supplier.CompanyName,
                supplier.ContactName,
                supplier.ContactTitle,
                supplier.Address,
                supplier.City,
                supplier.Region,
                supplier.PostalCode,
                supplier.Country,
                supplier.Phone,
                supplier.Fax,
                supplier.HomePage
            });

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            await _context.Database.ExecuteSqlRawAsync("DeleteSupplier @p0", parameters: new Object[] { id });
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
