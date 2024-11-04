using Strategy.Models;

namespace Strategy.DTOs;

public class CustomerTaxDto
{
    public CustomerType CustomerType { get; set; }
    public decimal Amount { get; set; }
}