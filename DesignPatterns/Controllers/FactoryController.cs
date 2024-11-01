using AbstractFactory.Managers;
using AbstractFactory.Models;
using FactoryMethod.Factory;
using FactoryMethod.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FactoryController : ControllerBase
{
    private readonly IDocumentFactory _documentFactory;
    private readonly IUIFactoryManager _uiFactoryManager;

    public FactoryController(IDocumentFactory documentFactory, IUIFactoryManager uiFactoryManager)
    {
        _documentFactory = documentFactory;
        _uiFactoryManager = uiFactoryManager;
    }

    [HttpPost("method")]
    public IActionResult CreateDocument(DocumentType documentType)
    {
        var document = _documentFactory.CreateDocument(documentType);
        document.Open();
        document.Save();
        document.Close();

        return Ok($"Document of type {documentType} created successfully.");
    }

    [HttpPost("abstract")]
    public IActionResult CreateUI(OperationalSystemType systemType)
    {
        var factory = _uiFactoryManager.GetFactory(systemType);

        var button = factory.CreateButton();
        var notification = factory.CreateNotification();

        button.Click();
        notification.Send();

        return Ok($"UI for OS of type {systemType} created successfully.");
    }
}
