namespace FactoryMethod.Models;

public interface IDocument
{
    void Open();
    void Close();
    void Save();
}
