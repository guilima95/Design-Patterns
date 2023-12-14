using Facade.Domain.Entities;
using Facade.Domain.Interfaces;

namespace Facade.Domain;

public class PaymentCreditService(IPaymentCardCreditServiceFacade paymentCardCreditServiceFacade) : IPaymentService
{
    private readonly IPaymentCardCreditServiceFacade _paymentCardCreditServiceFacade = paymentCardCreditServiceFacade;

    public async Task<Payment> DoPayment(Payment payment, Order order)
    {
        payment.Amount = order.Products.Sum(p => p.Value);
        bool result = await _paymentCardCreditServiceFacade.DoPayment(payment, order);

        if (result)
        {
            payment.Status = Enums.PaymentStatus.Done;
            return payment;
        }

        payment.Status = Enums.PaymentStatus.Refused;
        return payment;
    }
}
