using Facade.Domain.Entities;

namespace Facade.Domain.Interfaces;

public interface IPaymentCardCreditServiceFacade
{
    Task<bool> DoPayment(Payment payment, Order order);
}
