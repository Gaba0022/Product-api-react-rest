namespace backend.Data.DTOs;

public class LerProduto
{
    public string Nome { get; set; }
    public float Preco { get; set; }
    public string Categoria { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
