namespace Facade.Domain.Entities;

public class Order(Guid id, string description, List<Product> products)
{
    public Guid Id { get; set; } = id;

    public string Description { get; set; } = description;

    public List<Product> Products { get; set; } = products;
}
