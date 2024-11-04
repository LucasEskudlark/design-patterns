using Microsoft.Extensions.DependencyInjection;
using Strategy.Factory;
using Strategy.Models;
using Strategy.Strategy;

namespace Strategy.Extensions;

public static class StrategyConfigurationExtensions
{
    public static void ConfigureStrategy(this IServiceCollection services)
    {
        var strategyType = typeof(ICustomerTaxStrategy);
        var strategyTypes = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => strategyType.IsAssignableFrom(p) && !p.IsInterface);

        foreach (var type in strategyTypes)
        {
            services.AddSingleton(type);
            services.AddSingleton(strategyType, serviceProvider =>
                serviceProvider.GetRequiredService(type));
        }

        services.AddSingleton<ICustomerTaxStrategyFactory>(serviceProvider =>
        {
            var strategies = serviceProvider.GetServices<ICustomerTaxStrategy>();
            var strategyDictionary = strategies.ToDictionary(
                strategy => strategy.CustomerType,
                strategy => strategy);

            return new CustomerTaxStrategyFactory(strategyDictionary);
        });
    }
}