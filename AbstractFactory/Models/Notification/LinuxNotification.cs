namespace AbstractFactory.Models.Notification;

public class LinuxNotification : Notification
{
    public override void Send()
    {
        LogOperation();
        Console.WriteLine("Linux notification was sent");
    }
}
