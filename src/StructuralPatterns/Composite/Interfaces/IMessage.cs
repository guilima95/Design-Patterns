namespace Composite.Interfaces;

public interface IMessage
{
    public string Name { get; set; }

    void Result(int sub);
}
