namespace AbstractFactory.Models.Notification;

public abstract class Notification
{
    public void LogOperation()
    {
        Console.WriteLine("A notification will be sent");
    }

    public abstract void Send();
}
