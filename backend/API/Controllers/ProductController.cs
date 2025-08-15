using backend.Application.DTOs;
using backend.Application.Services;
using backend.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace backend.API.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    private readonly ProductService _service;

    public ProductController(ProductService service)
    {
        _service = service;
    }

    /// <summary>
    /// Cria um novo produto.
    /// </summary>
    /// <param name="dto">Dados do produto a ser criado.</param>
    /// <returns>O produto criado.</returns>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<Product>> Create([FromBody] CreateProductDto dto)
    {
        var product = await _service.CreateProductAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
    }

    /// <summary>
    /// Retorna todos os produtos cadastrados.
    /// </summary>
    /// <returns>Lista de produtos.</returns>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<Product>>> GetAll()
    {
        var products = await _service.GetAllProductsAsync();
        return Ok(products);
    }

    /// <summary>
    /// Retorna um produto específico pelo seu Id.
    /// </summary>
    /// <param name="id">Id do produto.</param>
    /// <returns>O produto correspondente ou NotFound se não existir.</returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetById(int id)
    {
        var product = await _service.GetAllProductsAsync();
        var found = product.FirstOrDefault(p => p.Id == id);
        if (found == null) return NotFound();
        return Ok(found);
    }
}
