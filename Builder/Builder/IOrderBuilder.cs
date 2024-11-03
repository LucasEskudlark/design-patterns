using Builder.Models;

namespace Builder.Builder;

public interface IOrderBuilder
{
    IOrderBuilder SetCustomer(string name);
    IOrderBuilder SetShippingAddress(string address);
    IOrderBuilder SetAmount(decimal amount);
    IOrderBuilder SetPaymentMethod(PaymentMethod method);
    IOrderBuilder AddItems(List<string> items);
    Order Build();
}
