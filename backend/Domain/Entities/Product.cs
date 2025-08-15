using System.ComponentModel.DataAnnotations;

namespace backend.Domain.Entities;

public class Product
{
    [Key]
    [Required(ErrorMessage = "The id is required")]
    public int Id { get; set; }

    [Required(ErrorMessage = "The nome is required")]
    public string Name { get; set; }

    [Required(ErrorMessage = "The preco is required")]
    public float Price { get; set; }

    [Required(ErrorMessage = "The categoria is required")]
    public string Category { get; set; }
}
