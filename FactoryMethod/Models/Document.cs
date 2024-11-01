namespace FactoryMethod.Models;

public abstract class Document
{
    public abstract void Open();
    public abstract void Close();
    public abstract void Save();

    public void LogMessage()
    {
        Console.WriteLine("This is a base method message, equal for every derived class");
    }
}
