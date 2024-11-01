using AbstractFactory.Factory;
using AbstractFactory.Managers;
using AbstractFactory.Models;
using Microsoft.Extensions.DependencyInjection;

namespace AbstractFactory.Extensions;

public static class AbstractFactoryConfigurationExtensions
{
    public static void ConfigureAbstractFactory(this IServiceCollection services)
    {
        services.AddSingleton<WindowsUIFactory>();
        services.AddSingleton<LinuxUIFactory>();

        services.AddSingleton<IUIFactoryManager>(serviceProvider =>
        {
            var factories = new Dictionary<OperationalSystemType, IUIFactory>
            {
                { OperationalSystemType.Windows, serviceProvider.GetRequiredService<WindowsUIFactory>() },
                { OperationalSystemType.Linux, serviceProvider.GetRequiredService<LinuxUIFactory>() }
            };

            return new UIFactoryManager(factories);
        });
    }
}
