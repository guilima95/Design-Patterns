using AbstractFactory.Enums;

namespace AbstractFactory.Abstractions
{
    //AbstractProductB
    public abstract class Pizza : PastaBase
    {
        protected Pizza(TypePasta typePasta, string name, List<string> ingredients) : base(typePasta, name, ingredients)
        {
        }
    }
}