using Composite.Interfaces;

namespace Composite;

public class InputMessage : IMessage
{
    public InputMessage(string name)
    {
        Name = name;
    }

    public string Name { get; set; } = null!;

    public void Result(int sub)
    {
        Console.WriteLine(new string('-', sub) + Name);
    }
}
