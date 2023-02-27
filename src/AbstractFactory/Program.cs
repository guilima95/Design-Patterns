/*
The Abstract Factory design pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.
Client -> Program.cs

AbstractProductA -> Cake
AbstractProductB -> Pizza

CreateProductA -> CakeFactory
CreateProductB -> PizzaFactory

ProductA -> Cake
ProductB -> Pizza

Reference: https://www.dofactory.com/net/abstract-factory-design-pattern
*/


using AbstractFactory;
using AbstractFactory.Enums;
using AbstractFactory.Factory;

// Get factories:
var cakeFactory = PastaAbstractFactory.CreateFactoryPastas(AbstractFactory.Enums.TypePasta.Cake);
var pizzaFactory = PastaAbstractFactory.CreateFactoryPastas(AbstractFactory.Enums.TypePasta.Pizza);

// Create the objects with base on type: CAKE
var cakeOne = cakeFactory.CreatePasta((TypePasta)TypeCake.Chocolate);
var cakeTwo = cakeFactory.CreatePasta((TypePasta)TypeCake.Orange);

var pizzaOne = pizzaFactory.CreatePasta((TypePasta)TypePizza.Cheese);
var pizzaTwo = pizzaFactory.CreatePasta((TypePasta)TypePizza.Chicken);

// Show details:
Details(cakeOne);
Details(cakeTwo);
Details(pizzaOne);
Details(pizzaTwo);


static void Details(PastaBase pastaBase)
{
    Console.WriteLine($"Type: {pastaBase.TypePasta}");
    Console.WriteLine($"Name: {pastaBase.Name}");
    Console.WriteLine($"Ingredients:");
    PrintIngredients(pastaBase);
    Console.WriteLine("\n");
}

static void PrintIngredients(PastaBase pastaBase)
{
    pastaBase.Ingredients.ForEach(a => Console.WriteLine("{0}\t", a.ToString()));
}