using AbstractFactory.Factory;
using AbstractFactory.Models;

namespace AbstractFactory.Managers;

public class UIFactoryManager : IUIFactoryManager
{
    private readonly IDictionary<OperationalSystemType, IUIFactory> _factories;

    public UIFactoryManager(IDictionary<OperationalSystemType, IUIFactory> factories)
    {
        _factories = factories;
    }

    public IUIFactory GetFactory(OperationalSystemType osType)
    {
        if (_factories.TryGetValue(osType, out var factory))
        {
            return factory;
        }
        throw new NotSupportedException($"OS type '{osType}' is not supported.");
    }
}
