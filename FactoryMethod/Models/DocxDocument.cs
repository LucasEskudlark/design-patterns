namespace FactoryMethod.Models;

public class DocxDocument : Document
{
    public override void Open()
    {
        LogMessage();
        Console.WriteLine("Opening Docx document...");
    }

    public override void Close()
    {
        Console.WriteLine("Closing Docx document...");
    }

    public override void Save()
    {
        Console.WriteLine("Saving Docx document...");
    }
}
