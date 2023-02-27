namespace FactoryMethod
{
    public class ConcreteCreatorPaymentRent : CreatorPayment
    {
        public override Payment Pay()
        {
            return new ConcretePaymentRent();
        }
    }
}