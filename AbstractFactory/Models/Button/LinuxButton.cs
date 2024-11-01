namespace AbstractFactory.Models.Button;

internal class LinuxButton : Button
{
    public override void Click()
    {
        LogOperation();
        Console.WriteLine("Linux button was clicked");
    }
}
