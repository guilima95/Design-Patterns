namespace FactoryMethod
{
    public class CreatorPaymentBuy : CreatorPayment
    {
        public override Payment Pay()
        {
            return new PaymentBuy();
        }
    }
}