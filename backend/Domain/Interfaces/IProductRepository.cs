using backend.Domain.Entities;

namespace backend.Domain.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllProductsAsync();
    Task<Product> AddProductAsync(Product product);
    Task<Product?> GetProductByIdAsync(int id);
}
