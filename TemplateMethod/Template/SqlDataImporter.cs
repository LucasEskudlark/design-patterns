namespace TemplateMethod.Template;

public class SqlDataImporter : DataImporter
{
    public override void Connect()
    {
        Console.WriteLine("Connecting to SQL server");
    }

    public override void Disconnect()
    {
        Console.WriteLine("Disconnecting from SQL server");
    }

    public override void ExtractData()
    {
        Console.WriteLine("Extracting data from SQL database");
    }

    public override void LoadData()
    {
        Console.WriteLine("Loading data from SQL database");
    }
}