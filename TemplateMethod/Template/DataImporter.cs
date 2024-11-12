namespace TemplateMethod.Template;

public abstract class DataImporter : IDataImporter
{
    public void ImportData()
    {
        Connect();
        ExtractData();
        TransformData();
        LoadData();
        Disconnect();
    }
    
    public abstract void Connect();
    public abstract void ExtractData();
    public virtual void TransformData()
    {
        Console.WriteLine("Transforming data in abstract class");
    }
    public abstract void LoadData();
    public abstract void Disconnect();
}