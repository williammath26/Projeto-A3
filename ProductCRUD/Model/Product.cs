using System.ComponentModel.DataAnnotations.Schema;

[Table("products")]
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }= string.Empty;
    public decimal Price { get; set; }
}
