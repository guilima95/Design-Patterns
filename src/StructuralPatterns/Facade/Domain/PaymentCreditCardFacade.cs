using Facade.CrossCutting;
using Facade.Domain.Entities;
using Facade.Domain.Interfaces;

namespace Facade.Domain;

public class PaymentCreditCardFacade : IPaymentCardCreditServiceFacade
{
    private readonly IPayPalGateway _payPalGateway;

    public PaymentCreditCardFacade(IPayPalGateway payPalGateway)
    {
        _payPalGateway = payPalGateway;
    }

    public async Task<bool> DoPayment(Payment payment, Order order)
    {
        string apiKey = "Get config file";
        string encriptionKey = "Get config file";

        string serviceKey = await _payPalGateway
            .GetPayPalServiceKeyAsync(apiKey, encriptionKey);

        string cardHashKey = await _payPalGateway
            .GetCardHashKeyAsync(serviceKey, payment.CardNumber);

        return await _payPalGateway
            .CommitTransactionAsync(cardHashKey, order.Id, payment.Amount);
    }
}
