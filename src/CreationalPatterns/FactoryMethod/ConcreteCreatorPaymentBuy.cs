namespace FactoryMethod;

public class ConcreteCreatorPaymentBuy : CreatorPayment
{
    public override Payment Pay()
    {
        return new ConcretePaymentBuy();
    }
}