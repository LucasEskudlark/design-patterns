using AbstractFactory.Models.Button;
using AbstractFactory.Models.Notification;

namespace AbstractFactory.Factory;

public interface IUIFactory
{
    Button CreateButton();
    Notification CreateNotification();
}
