using FactoryMethod;

/// <summary>
/// Abstract Method:
/// The Factory Method design pattern defines an interface for creating an object, but let subclasses decide which class to instantiate. 
/// This pattern lets a class defer instantiation to subclasses.
/// An abstract method must be defined within an abstract class or an interface, 
/// which means that the class or interface that declares the abstract method must also be marked as abstract.
/// </summary>
Console.WriteLine("Hello! Let's see about Factory Method!");
Menu();

static void Menu()
{
    Console.WriteLine("Choice your debt:");
    Console.WriteLine(".................");
    Console.WriteLine("1 - Rent");
    Console.WriteLine("2 - Buy");

    ConsoleKeyInfo option = Console.ReadKey();

    Console.WriteLine("");
    Console.WriteLine("...............");
    Console.WriteLine("");

    switch (option.KeyChar)
    {
        case '1':
            ConcreteCreatorPaymentRent creatorRent = new ConcreteCreatorPaymentRent();
            Payment paymentRent = creatorRent.Pay();
            Console.WriteLine("What is description?");
            string? descRent = Console.ReadLine();
            Console.WriteLine("What is type?");
            string? typeRent = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("...............");
            Console.WriteLine("");

            if (string.IsNullOrEmpty(descRent) || string.IsNullOrEmpty(typeRent))
            {
                Console.WriteLine("Ops, none option found with this key. Description and Type cannot be null");
                break;
            }

            paymentRent.FillProps(descRent.ToString(), typeRent.ToString());
            paymentRent.Pay(2000);
            break;
        case '2':
            ConcreteCreatorPaymentBuy creatorBuy = new ConcreteCreatorPaymentBuy();
            Payment paymentBuy = creatorBuy.Pay();
            Console.WriteLine("What is description?");
            string? descBuy = Console.ReadLine();
            Console.WriteLine("What is type?");
            string? typeBuy = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("...............");
            Console.WriteLine("");

            if (string.IsNullOrEmpty(descBuy) || string.IsNullOrEmpty(typeBuy))
            {
                Console.WriteLine("Ops, none option found with this key. Description and Type cannot be null");
                break;
            }

            paymentBuy.FillProps(descBuy.ToString(), typeBuy.ToString());
            paymentBuy.Pay(12000);
            break;
        default:
            Console.WriteLine("None option found with this key. Please, try again!");
            break;
    }
}








