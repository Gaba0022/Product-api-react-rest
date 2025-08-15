using System.ComponentModel.DataAnnotations;

namespace backend.Data.DTOs;

public class CriarProdutoDTO
{
    [Required(ErrorMessage = "The nome is required")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "The preco is required")]
    public float Preco { get; set; }

    [Required(ErrorMessage = "The categoria is required")]
    public string Categoria { get; set; }
}
