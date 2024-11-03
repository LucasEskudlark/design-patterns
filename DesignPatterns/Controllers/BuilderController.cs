using Builder.Builder;
using Builder.DTOs;
using Builder.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BuilderController : ControllerBase
{
    private readonly IOrderBuilder _orderBuilder;

    public BuilderController(IOrderBuilder orderBuilder)
    {
        _orderBuilder = orderBuilder;
    }

    [HttpPost]
    public IActionResult BuildOrder([FromBody] OrderDto orderDto)
    {
        var order = _orderBuilder
            .SetCustomer(orderDto.CustomerName)
            .SetShippingAddress(orderDto.ShippingAddress)
            .SetPaymentMethod(orderDto.PaymentMethod)
            .SetAmount(orderDto.TotalAmount)
            .AddItems(orderDto.Items)
            .Build();

        return Ok(order);
    }
}
