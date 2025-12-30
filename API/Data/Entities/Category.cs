using System.Collections.Generic;

namespace API.Data.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string? Slug { get; set; }
    public Guid? ParentCategoryId { get; set; }
    public Category? ParentCategory { get; set; }
    public ICollection<Product>? Products { get; set; }
}
