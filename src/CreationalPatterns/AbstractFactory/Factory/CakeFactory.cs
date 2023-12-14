using AbstractFactory.Concretes;
using AbstractFactory.Enums;

namespace AbstractFactory.Factory
{
    public class CakeFactory : PastaAbstractFactory
    {
        public override PastaBase CreatePasta(TypePasta type)
        {
            var typeCake = (TypeCake)type;

            switch (typeCake)
            {
                case TypeCake.Chocolate:
                    return new CakeChocolate(type, "Chocolate", new List<string> {"Flour", "Chocolate"});
                case TypeCake.Orange:
                    return new CakeOrange(type, "Orange", new List<string> {"Flour", "Orange"});
                default:
                    throw new ArgumentOutOfRangeException("Type not implement");
            }

        }
    }
}