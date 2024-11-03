namespace Builder.Models;

public class Order
{
    public string? CustomerName { get; set; }
    public string? ShippingAddress { get; set; }
    public decimal TotalAmount { get; set; }
    public DateTime OrderDate { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public string? Status { get; set; }
    public List<string>? Items { get; set; }
}