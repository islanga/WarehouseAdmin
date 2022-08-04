using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseAdminAPI.Data;
using WarehouseAdminAPI.Models;

namespace WarehouseAdminAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        protected readonly WarehouseDbContext _context;

        public CategoryController(WarehouseDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Categories>> Get() => await _context.categories.FromSqlRaw("GetAllCategories").ToListAsync();

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Users), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(int id)
        {
            var user = await _context.categories.FromSqlRaw($"SearchCategory {id}").ToListAsync();
            return user == null ? NotFound() : Ok(user);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create(Categories category)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await _context.Database.ExecuteSqlRawAsync("InsertCategory @p0, @p1", parameters: new[] { category.CategoryName, category.Description });

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = category.CategoryID }, category);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, Categories category)
        {
            await _context.Database.ExecuteSqlRawAsync("UpdateCategory @p0, @p1, @p2", parameters: new Object[] { id, category.CategoryName, category.Description });

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            await _context.Database.ExecuteSqlRawAsync("DeleteCategory @p0", parameters: new Object[] { id });
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
