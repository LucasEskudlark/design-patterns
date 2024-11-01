namespace AbstractFactory.Models.Notification;

internal class WindowsNotification : Notification
{
    public override void Send()
    {
        LogOperation();
        Console.WriteLine("Windows notification was sent");
    }
}
