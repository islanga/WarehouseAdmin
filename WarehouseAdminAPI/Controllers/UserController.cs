using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WarehouseAdminAPI.Data;
using WarehouseAdminAPI.Models;
using WarehouseAdminAPI.Tools;

namespace WarehouseAdminAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        protected readonly WarehouseDbContext _context;

        public UserController(WarehouseDbContext context) => _context = context;

        [HttpGet]
        public async Task<IEnumerable<Users>> Get() => await _context.users.FromSqlRaw("GetUsers").ToListAsync();

        [HttpGet("{email}")]
        [ProducesResponseType(typeof(Suppliers), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(string email)
        {
            var user = await _context.users.FromSqlRaw($"SearchUser '{email}'").ToListAsync();
            return user == null ? NotFound() : Ok(user);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create(Users user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            String password = Password.hashPassword(user.Password);
            await _context.Database.ExecuteSqlRawAsync("InsertUser @p0, @p1", parameters: new Object[] {
                user.Email,
                password
            });

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, Users user)
        {
            String password = Password.hashPassword(user.Password);
            await _context.Database.ExecuteSqlRawAsync("UpdateUser @p0, @p1, @p2", parameters: new Object[] {
                id,
                user.Email,
                password
            });

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            await _context.Database.ExecuteSqlRawAsync("DeleteUser @p0", parameters: new Object[] { id });
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
