namespace FactoryMethod;

public class ConcretePaymentRent : Payment
{
    public override void FillProps(string description, string type)
    {
        Description = description;
        Type = type;
    }

    public override void Pay(decimal value)
    {
        {
            Console.WriteLine($@"The account {Description} was paid by {Type} on value of {value}");
        }
    }
}