using Strategy.Models;

namespace Strategy.Strategy;

public class CpfCustomerTaxStrategy : ICustomerTaxStrategy
{
    private const decimal TaxPercentage = 0.15m;

    public CustomerType CustomerType => CustomerType.CPF;

    public decimal CalculateCustomerTaxAmount(decimal amount)
    {
        return amount * TaxPercentage;
    }
}