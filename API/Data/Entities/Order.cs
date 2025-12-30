using System.Collections.Generic;

namespace API.Data.Entities;

public class Order : BaseEntity
{
    public string OrderNumber { get; set; } = string.Empty;
    public Guid UserId { get; set; }
    public User? User { get; set; }
    public decimal Total { get; set; }
    public string? Status { get; set; }
    public Guid? ShippingAddressId { get; set; }
    public Address? ShippingAddress { get; set; }
    public Guid? BillingAddressId { get; set; }
    public Address? BillingAddress { get; set; }
    public ICollection<OrderItem>? Items { get; set; }
}
