namespace FactoryMethod
{
    public class CreatorPaymentRent : CreatorPayment
    {
        public override Payment Pay()
        {
            return new PaymentRent();
        }
    }
}