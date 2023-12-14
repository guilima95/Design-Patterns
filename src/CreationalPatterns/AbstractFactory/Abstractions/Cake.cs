using AbstractFactory.Enums;

namespace AbstractFactory.Abstractions
{
    //AbstractProductA
    public abstract class Cake : PastaBase
    {
        protected Cake(TypePasta typePasta, string name, List<string> ingredients) : base(typePasta, name, ingredients)
        {
        }
    }
}