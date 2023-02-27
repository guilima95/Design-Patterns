using AbstractFactory.Concretes;
using AbstractFactory.Enums;

namespace AbstractFactory.Factory
{
    public class PizzaFactory : PastaAbstractFactory
    {
        public override PastaBase CreatePasta(TypePasta type)
        {
            var typePizza = (TypePizza)type;

            switch (typePizza)
            {
                case TypePizza.Cheese:
                    return new PizzaCheese(type, "Cheese", new List<string> { "1/2 Kg Cheese", "Tomato", "Flour" });
                case TypePizza.Chicken:
                    return new PizzaChicken(type, "Chicken", new List<string> { "1Kg Chicken", "Tomato", "Flour" });
                default:
                    throw new ArgumentOutOfRangeException("Type not implement");
            }

        }
    }
}