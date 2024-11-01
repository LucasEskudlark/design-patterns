namespace FactoryMethod.Models;

public class PdfDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening PDF document...");
    }

    public void Close()
    {
        Console.WriteLine("Closing PDF document...");
    }

    public void Save()
    {
        Console.WriteLine("Saving PDF document...");
    }
}
