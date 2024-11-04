using Strategy.Models;
using Strategy.Strategy;

namespace Strategy.Factory;

public class CustomerTaxStrategyFactory : ICustomerTaxStrategyFactory
{
    private readonly IDictionary<CustomerType, ICustomerTaxStrategy> _strategies;

    public CustomerTaxStrategyFactory(IDictionary<CustomerType, ICustomerTaxStrategy> strategies)
    {
        _strategies = strategies;
    }

    public ICustomerTaxStrategy GetStrategy(CustomerType customerType)
    {
        if(_strategies.TryGetValue(customerType, out var strategy))
        {
            return strategy;
        }

        throw new NotSupportedException($"Customer type '{customerType}' is not supported.");
    }
}