namespace TemplateMethod.Template;

public class CsvDataImporter : DataImporter
{
    public override void Connect()
    {
        Console.WriteLine("Connecting to CSV server");
    }

    public override void Disconnect()
    {
        Console.WriteLine("Disconnecting from CSV server");
    }

    public override void ExtractData()
    {
        Console.WriteLine("Extracting data from CSV sheet");
    }

    public override void LoadData()
    {
        Console.WriteLine("Loading data from CSV sheet");
    }

    public override void TransformData()
    {
        Console.WriteLine("Transforming data in the CSV importer class. This is an override.");
    }
}