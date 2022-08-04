using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseAdminAPI.Data;
using WarehouseAdminAPI.Models;

namespace WarehouseAdminAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        protected readonly WarehouseDbContext _context;

        public ProductController(WarehouseDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Products>> Get() => await _context.products.FromSqlRaw("GetAllProducts").ToListAsync();

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Users), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id)
        {
            var user = await _context.products.FromSqlRaw($"SearchProduct {id}").ToListAsync();
            return user == null ? NotFound() : Ok(user);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create(Products product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _context.Database.ExecuteSqlRawAsync("InsertProduct @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8", parameters: new Object[] { 
                product.ProductName, 
                product.SupplierID,
                product.CategoryID,
                product.QuantityPerUnit,
                product.UnitPrice,
                product.UnitsInStock,
                product.UnitsOnOrder,
                product.ReorderLevel,
                product.Discontinued
            });

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = product.ProductID }, product);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, Products product)
        {
            await _context.Database.ExecuteSqlRawAsync("UpdateProduct @p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9", parameters: new Object[] {
                id,
                product.ProductName,
                product.SupplierID,
                product.CategoryID,
                product.QuantityPerUnit,
                product.UnitPrice,
                product.UnitsInStock,
                product.UnitsOnOrder,
                product.ReorderLevel,
                product.Discontinued
            });

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            await _context.Database.ExecuteSqlRawAsync("DeleteProduct @p0", parameters: new Object[] { id });
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
