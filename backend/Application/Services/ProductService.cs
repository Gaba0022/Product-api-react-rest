using backend.Application.DTOs;
using backend.Domain.Entities;
using backend.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.Services;

public class ProductService
{

    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<Product> CreateProductAsync(CreateProductDto dto)
    {
        var product = new Product
        {
            Name = dto.Name,
            Price = dto.Price,
            Category = dto.Category,
        };

        return await _repository.AddProductAsync(product);
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await _repository.GetAllProductsAsync();
    }

}
