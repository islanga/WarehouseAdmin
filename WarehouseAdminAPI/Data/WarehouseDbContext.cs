using WarehouseAdminAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace WarehouseAdminAPI.Data
{
    public class WarehouseDbContext : DbContext
    {
        public WarehouseDbContext(DbContextOptions options) : base(options)
        {}

        public DbSet<Users> users { get; set; }
        public DbSet<Categories> categories { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Suppliers> suppliers { get; set; }
    }
}
