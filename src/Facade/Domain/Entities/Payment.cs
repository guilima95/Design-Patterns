using Facade.Domain.Enums;

namespace Facade.Domain.Entities;

public class Payment(
    Guid id, string cardNumber,
    PaymentStatus status, PaymentMethod method, Guid orderId)
{
    public Guid Id { get; set; } = id;

    public decimal Amount { get; set; }

    public string CardNumber { get; set; } = cardNumber;

    public PaymentStatus Status { get; set; } = status;

    public PaymentMethod Method { get; set; } = method;

    public Guid OrderId { get; set; } = orderId;
}