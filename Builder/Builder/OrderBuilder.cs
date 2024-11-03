using Builder.Models;

namespace Builder.Builder;

public class OrderBuilder : IOrderBuilder
{
    private readonly Order _order;

    public OrderBuilder()
    {
        _order = new()
        {
            OrderDate = DateTime.Now,
            Status = "Pending",
            Items = []
        };
    }

    public IOrderBuilder AddItems(List<string> items)
    {
        foreach (var item in items)
        {
            _order.Items?.Add(item);
        }
        
        return this;
    }

    public IOrderBuilder SetAmount(decimal amount)
    {
        _order.TotalAmount = amount;
        return this;
    }

    public IOrderBuilder SetCustomer(string name)
    {
        _order.CustomerName = name;
        return this;
    }

    public IOrderBuilder SetPaymentMethod(PaymentMethod method)
    {
        _order.PaymentMethod = method;
        return this;
    }

    public IOrderBuilder SetShippingAddress(string address)
    {
        _order.ShippingAddress = address;
        return this;
    }

    public Order Build()
    {
        return _order;
    }

}