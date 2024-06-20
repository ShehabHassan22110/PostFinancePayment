using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IProductService
    {
        Task<Product> Create(Product product);
        void Update(Product product);
        void Delete(Product product);
        Task<Product> GetById(int id);
        Task<IEnumerable<Product>> Get();
    }
}
