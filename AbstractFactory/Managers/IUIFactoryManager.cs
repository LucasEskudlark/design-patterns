using AbstractFactory.Factory;
using AbstractFactory.Models;

namespace AbstractFactory.Managers;

public interface IUIFactoryManager
{
    IUIFactory GetFactory(OperationalSystemType osType);
}
