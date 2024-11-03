using Builder.Models;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace Builder.DTOs;

public class OrderDto
{
    public required string CustomerName { get; set; }
    public required string ShippingAddress { get; set; }
    public decimal TotalAmount { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public required List<string> Items { get; set; }
}