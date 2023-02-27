using AbstractFactory.Abstractions;
using AbstractFactory.Enums;

namespace AbstractFactory.Concretes
{
    //ProductA2
    public class CakeOrange : Cake
    {
        public CakeOrange(TypePasta typePasta, string name, List<string> ingredients) : base(typePasta, name, ingredients)
        {
        }
    }
}