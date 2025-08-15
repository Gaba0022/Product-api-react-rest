using System.ComponentModel.DataAnnotations;

namespace backend.Models;

public class Produtos
{
    [Key]
    [Required(ErrorMessage = "The id is required")]
    public int Id { get; set; }

    [Required(ErrorMessage = "The nome is required")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "The preco is required")]
    public float Preco {  get; set; }

    [Required(ErrorMessage = "The categoria is required")]
    public string Categoria { get; set; }
}
