using Microsoft.EntityFrameworkCore;
using CoreEF.Models;

namespace CoreEF.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

    }
}
