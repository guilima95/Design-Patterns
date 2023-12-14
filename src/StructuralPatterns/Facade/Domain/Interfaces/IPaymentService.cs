using Facade.Domain.Entities;

namespace Facade.Domain.Interfaces;

public interface IPaymentService
{
    Task<Payment> DoPayment(Payment payment, Order order);
}
