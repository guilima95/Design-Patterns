using AbstractFactory.Abstractions;
using AbstractFactory.Enums;

namespace AbstractFactory.Concretes
{
    //ProductB2
    public class PizzaChicken : Pizza
    {
        public PizzaChicken(TypePasta typePasta, string name, List<string> ingredients) : base(typePasta, name, ingredients)
        {
        }
    }
}