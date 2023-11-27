namespace Adapter;

// Target Class:
// defines the domain-specific interface that Client uses.
public class Logger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"Log mensagem: {message}");
    }

    public void LogException(Exception exception)
    {
        Console.WriteLine($"Log exception: {exception.Message}");
    }
}
