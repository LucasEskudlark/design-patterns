using Microsoft.AspNetCore.Mvc;
using Strategy.DTOs;
using Strategy.Factory;

namespace DesignPatterns.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StrategyController : ControllerBase
{
    private readonly ICustomerTaxStrategyFactory _customerTaxStrategyFactory;

    public StrategyController(ICustomerTaxStrategyFactory customerTaxStrategyFactory)
    {
        _customerTaxStrategyFactory = customerTaxStrategyFactory;
    }

    [HttpPost]
    public IActionResult GetCustomerTaxAmount(CustomerTaxDto customerTaxDto)
    {
        var strategy = _customerTaxStrategyFactory.GetStrategy(customerTaxDto.CustomerType);

        var taxAmount = strategy.CalculateCustomerTaxAmount(customerTaxDto.Amount);

        return Ok(new { taxAmount });
    }
}
