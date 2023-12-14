using Composite.Interfaces;
using System.Collections;

namespace Composite;

public class Message : IMessage, IEnumerable<IMessage>
{
    public string Name { get; set; } = null!;

    private readonly List<IMessage> _listMessages = [];

    public Message(string name)
    {
        Name = name;
    }

    public void Result(int sub)
    {
        Console.WriteLine(new string('-', sub) + Name);

        // Recursive method to show children messages:
        foreach (IMessage item in _listMessages)
        {
            item.Result(sub + 2);
        }
    }

    public void AddMessage(IMessage message)
    {
        _listMessages.Add(message);
    }

    public void RemoveMessage(IMessage message)
    {
        _listMessages.Remove(message);
    }

    public IMessage? GetMessage(string name)
    {
        return _listMessages.Find(m => m.Name == name);
    }

    public IEnumerator<IMessage> GetEnumerator()
    {
        return ((IEnumerable<IMessage>)_listMessages).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<IMessage>)_listMessages).GetEnumerator();
    }
}
