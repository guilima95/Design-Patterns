using AbstractFactory.Enums;

namespace AbstractFactory
{
    public abstract class PastaBase
    {
        public PastaBase(TypePasta typePasta, string name, List<string> ingredients)
        {
            TypePasta = typePasta;
            Name = name;
            Ingredients = ingredients;
        }

        public TypePasta TypePasta { get; set; }
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
    }
}