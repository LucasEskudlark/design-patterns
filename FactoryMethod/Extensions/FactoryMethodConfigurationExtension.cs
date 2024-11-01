using FactoryMethod.Factory;
using FactoryMethod.Models;
using Microsoft.Extensions.DependencyInjection;

namespace FactoryMethod.Extensions;

public static class FactoryMethodConfigurationExtension
{
    public static void ConfigureFactoryMethod(this IServiceCollection services)
    {
        services.AddTransient<DocxDocument>();
        services.AddTransient<PdfDocument>();

        var documentTypes = new Dictionary<DocumentType, Type>
        {
            { DocumentType.Docx, typeof(DocxDocument) },
            { DocumentType.Pdf, typeof(PdfDocument) }
        };

        services.AddSingleton<IDocumentFactory>(provider =>
            new DocumentFactory(documentTypes, provider));
    }
}
