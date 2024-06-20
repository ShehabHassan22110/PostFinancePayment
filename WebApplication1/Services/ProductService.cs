using Microsoft.EntityFrameworkCore;
using WebApplication1.Context;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ProductService:IProductService
    {
        private readonly ApplicationDbContext context;

        public ProductService(ApplicationDbContext context)
        {
            this.context = context;
        }


        public async Task<Product> Create(Product Product)
        {
            await context.Products.AddAsync(Product);
            context.SaveChanges();
            return Product;
        }



        public void Delete(Product Product)
        {
            context.Entry(Product).State = EntityState.Deleted;
            context.SaveChanges();

        }



        public async Task<IEnumerable<Product>> Get()
        {
            return await context.Products.ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await context.Products.SingleOrDefaultAsync(a => a.Id == id);
        }



        public void Update(Product Product)
        {
            context.Entry(Product).State = EntityState.Modified;
            context.SaveChanges();

        }
    }
}
