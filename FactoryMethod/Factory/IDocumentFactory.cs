using FactoryMethod.Models;

namespace FactoryMethod.Factory;

public interface IDocumentFactory
{
    IDocument CreateDocument(DocumentType documentType);
}
