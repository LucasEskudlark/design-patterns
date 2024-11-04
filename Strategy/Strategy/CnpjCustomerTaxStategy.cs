using Strategy.Models;

namespace Strategy.Strategy;

public class CnpjCustomerTaxStategy : ICustomerTaxStrategy
{
    private const decimal TaxPercentage = 0.3m;

    public CustomerType CustomerType => CustomerType.CNPJ;

    public decimal CalculateCustomerTaxAmount(decimal amount)
    {
        return amount * TaxPercentage;
    }
}