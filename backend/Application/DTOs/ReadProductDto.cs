namespace backend.Application.DTOs;

public class ReadProductDto
{
    public string Name { get; set; }
    public float Price { get; set; }
    public string Category { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
