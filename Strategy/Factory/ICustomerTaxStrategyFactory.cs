using Strategy.Models;
using Strategy.Strategy;

namespace Strategy.Factory;

public interface ICustomerTaxStrategyFactory
{
    ICustomerTaxStrategy GetStrategy(CustomerType customerType);
}