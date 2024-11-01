using FactoryMethod.Models;

namespace FactoryMethod.Factory;
public class DocumentFactory : IDocumentFactory
{
    private readonly IDictionary<DocumentType, Type> _documentTypes;
    private readonly IServiceProvider _serviceProvider;

    public DocumentFactory(IDictionary<DocumentType, Type> documentTypes, IServiceProvider serviceProvider)
    {
        _documentTypes = documentTypes;
        _serviceProvider = serviceProvider;
    }

    public IDocument CreateDocument(DocumentType documentType)
    {
        if (_documentTypes.TryGetValue(documentType, out var type))
        {
            if (_serviceProvider.GetService(type) is IDocument document)
            {
                return document;
            }
            throw new InvalidOperationException($"Unable to create an instance of {type.Name}.");
        }
        throw new NotSupportedException($"Document type '{documentType}' is not supported.");
    }
}

