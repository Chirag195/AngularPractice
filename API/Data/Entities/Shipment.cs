namespace API.Data.Entities;

public class Shipment : BaseEntity
{
    public Guid OrderId { get; set; }
    public Order? Order { get; set; }
    public string? Carrier { get; set; }
    public string? TrackingNumber { get; set; }
    public DateTime? ShippedAt { get; set; }
    public DateTime? DeliveredAt { get; set; }
    public string? Status { get; set; }
}
