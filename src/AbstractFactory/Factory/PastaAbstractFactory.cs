using AbstractFactory.Enums;

namespace AbstractFactory.Factory
{
    public abstract class PastaAbstractFactory
    {
        public abstract PastaBase CreatePasta(TypePasta type);

        public static PastaAbstractFactory CreateFactoryPastas(TypePasta type)
        {
            switch (type)
            {
                case TypePasta.Pizza:
                    return new PizzaFactory();
                case TypePasta.Cake:
                    return new CakeFactory();
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}