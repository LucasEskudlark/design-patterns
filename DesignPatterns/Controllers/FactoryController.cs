using FactoryMethod.Factory;
using FactoryMethod.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FactoryController : ControllerBase
{
    private readonly IDocumentFactory _documentFactory;

    public FactoryController(IDocumentFactory documentFactory)
    {
        _documentFactory = documentFactory;
    }

    [HttpPost]
    public IActionResult CreateDocument(DocumentType documentType)
    {
        var document = _documentFactory.CreateDocument(documentType);
        document.Open();
        document.Save();
        document.Close();

        return Ok($"Document of type {documentType} created successfully.");
    }
}
