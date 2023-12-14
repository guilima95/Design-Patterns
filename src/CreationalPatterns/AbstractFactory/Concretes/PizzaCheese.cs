using AbstractFactory.Abstractions;
using AbstractFactory.Enums;

namespace AbstractFactory.Concretes
{
    //ProductB1
    public class PizzaCheese : Pizza
    {
        public PizzaCheese(TypePasta typePasta, string name, List<string> ingredients) : base(typePasta, name, ingredients)
        {
        }
    }
}