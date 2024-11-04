using Strategy.Models;

namespace Strategy.Strategy;

public interface ICustomerTaxStrategy
{
    CustomerType CustomerType { get; }
    decimal CalculateCustomerTaxAmount(decimal amount);
}