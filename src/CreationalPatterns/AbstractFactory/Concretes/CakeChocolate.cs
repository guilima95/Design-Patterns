using AbstractFactory.Abstractions;
using AbstractFactory.Enums;

namespace AbstractFactory.Concretes
{
    //ProductA1
    public class CakeChocolate : Cake
    {
        public CakeChocolate(TypePasta typePasta, string name, List<string> ingredients) : base(typePasta, name, ingredients)
        {
        }
    }
}