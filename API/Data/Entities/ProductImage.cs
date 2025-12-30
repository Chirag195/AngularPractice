namespace API.Data.Entities;

public class ProductImage : BaseEntity
{
    public Guid ProductId { get; set; }
    public Product? Product { get; set; }
    public string Url { get; set; } = string.Empty;
    public bool IsPrimary { get; set; } = false;
}
