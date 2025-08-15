using System.ComponentModel.DataAnnotations;

namespace backend.Application.DTOs;

public class CreateProductDto
{
    [Required(ErrorMessage = "The nome is required")]
    public string Name { get; set; }

    [Required(ErrorMessage = "The preco is required")]
    public float Price { get; set; }

    [Required(ErrorMessage = "The categoria is required")]
    public string Category { get; set; }
}
