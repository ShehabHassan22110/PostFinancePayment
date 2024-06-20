using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed initial data
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Product 1", Price = 19.99m, Quantity = 10 },
                new Product { Id = 2, Name = "Product 2", Price = 29.99m, Quantity = 5 },
                new Product { Id = 3, Name = "Product 3", Price = 39.99m, Quantity = 6 }
            );
        }
    }
}
