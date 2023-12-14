using Composite.Interfaces;

namespace Composite;

public class DomainMessage : IMessage
{
    public DomainMessage(string name)
    {
        Name = name;
    }

    public string Name { get; set; } = null!;

    public void Result(int sub)
    {
        Console.WriteLine(new string('-', sub) + Name);
    }
}
