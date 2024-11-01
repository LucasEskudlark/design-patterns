using AbstractFactory.Models.Button;
using AbstractFactory.Models.Notification;

namespace AbstractFactory.Factory;

public class WindowsUIFactory : IUIFactory
{
    public Button CreateButton()
    {
        return new WindowsButton();
    }

    public Notification CreateNotification()
    {
        return new WindowsNotification();
    }
}
