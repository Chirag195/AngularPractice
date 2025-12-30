namespace API.Data.Entities;

public class Payment : BaseEntity
{
    public Guid OrderId { get; set; }
    public Order? Order { get; set; }
    public decimal Amount { get; set; }
    public string? PaymentMethod { get; set; }
    public string? TransactionId { get; set; }
    public string? Status { get; set; }
}
