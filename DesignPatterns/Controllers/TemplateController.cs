using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TemplateMethod.Template;

namespace DesignPatterns.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TemplateController : ControllerBase
{
    private readonly IDataImporter _dataImporter;

    public TemplateController(IDataImporter dataImporter)
    {
        _dataImporter = dataImporter;
    }

    [HttpPost]
    public IActionResult ProcessData()
    {

        _dataImporter.ImportData();

        return Ok();
    }
}
