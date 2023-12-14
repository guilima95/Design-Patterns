namespace FactoryMethod;

public abstract class Payment
{
    protected string Description { get; set; } = null!;
    protected string Type { get; set; } = null!;
    public abstract void Pay(decimal value);
    public abstract void FillProps(string description, string type);
}