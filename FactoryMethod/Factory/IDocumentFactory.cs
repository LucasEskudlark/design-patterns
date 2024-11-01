using FactoryMethod.Models;

namespace FactoryMethod.Factory;

public interface IDocumentFactory
{
    Document CreateDocument(DocumentType documentType);
}
