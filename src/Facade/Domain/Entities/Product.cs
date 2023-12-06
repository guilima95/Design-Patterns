namespace Facade.Domain.Entities;

public class Product(Guid id, string name, decimal value)
{
    public Guid Id { get; set; } = id;

    public string Name { get; set; } = name;

    public decimal Value { get; set; } = value;
}
