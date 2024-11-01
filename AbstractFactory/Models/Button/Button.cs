namespace AbstractFactory.Models.Button;

public abstract class Button
{
    public void LogOperation()
    {
        Console.WriteLine("Click method was called");
    }

    public abstract void Click();
}
