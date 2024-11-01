using AbstractFactory.Models.Button;
using AbstractFactory.Models.Notification;

namespace AbstractFactory.Factory;

public class LinuxUIFactory : IUIFactory
{
    public Button CreateButton()
    {
        return new LinuxButton();
    }

    public Notification CreateNotification()
    {
        return new LinuxNotification();
    }
}
