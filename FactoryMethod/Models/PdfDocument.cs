namespace FactoryMethod.Models;

public class PdfDocument : Document
{
    public override void Open()
    {
        LogMessage();
        Console.WriteLine("Opening PDF document...");
    }

    public override void Close()
    {
        Console.WriteLine("Closing PDF document...");
    }

    public override void Save()
    {
        Console.WriteLine("Saving PDF document...");
    }
}
