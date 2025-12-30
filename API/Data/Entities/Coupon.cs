namespace API.Data.Entities;

public class Coupon : BaseEntity
{
    public string Code { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string? DiscountType { get; set; } // e.g. Percentage, Fixed
    public decimal DiscountValue { get; set; }
    public DateTime? ExpiresAt { get; set; }
    public bool IsActive { get; set; } = true;
    public int? UsageLimit { get; set; }
}
