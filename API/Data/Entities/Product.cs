using System.Collections.Generic;

namespace API.Data.Entities;

public class Product : BaseEntity
{
    public string? SKU { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public Guid? CategoryId { get; set; }
    public Category? Category { get; set; }
    public int StockQuantity { get; set; }
    public bool IsActive { get; set; } = true;
    public ICollection<ProductImage>? Images { get; set; }
}
