using DotNet_CRUD_API.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_CRUD_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

    }
}
