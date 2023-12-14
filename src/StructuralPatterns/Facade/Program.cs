using Facade.CrossCutting;
using Facade.Domain;
using Facade.Domain.Entities;
using Facade.Domain.Enums;

namespace Facade;

public class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Initializing executing facade pattern using example real world.");

        List<Product> products =
        [
            new(Guid.NewGuid(), "Tenis", new Random().Next(500)),
            new(Guid.NewGuid(), "Shirt", new Random().Next(500)),
            new(Guid.NewGuid(), "Short", new Random().Next(500))
        ];

        Order order = new(Guid.NewGuid(), "", products);

        Payment payment = new(
            Guid.NewGuid(), "5555 2222 5555 9999",
            PaymentStatus.Pending, PaymentMethod.CreditCard, order.Id);

        PaymentCreditService service = new(new PaymentCreditCardFacade(new PayPalGateway()));

        Payment result = await service.DoPayment(payment, order);

        Console.WriteLine($"Payment was successfuly, status: {result.Status}");
    }
}
