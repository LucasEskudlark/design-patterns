namespace FactoryMethod.Models;

public class DocxDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening Docx document...");
    }

    public void Close()
    {
        Console.WriteLine("Closing Docx document...");
    }

    public void Save()
    {
        Console.WriteLine("Saving Docx document...");
    }
}
