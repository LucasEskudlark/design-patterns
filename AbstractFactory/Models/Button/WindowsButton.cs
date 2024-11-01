namespace AbstractFactory.Models.Button;

public class WindowsButton : Button
{
    public override void Click()
    {
        LogOperation();
        Console.WriteLine("Windows button was clicked");
    }
}
