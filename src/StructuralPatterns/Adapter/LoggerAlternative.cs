namespace Adapter;

// Adaptee class:
// defines an existing interface that needs adapting.
public class LoggerAlternative : ILoggerCustom
{
    public void Log(string message)
    {
        Console.WriteLine($"Log custom mensagem: {message}");
    }

    public void LogException(Exception exception)
    {
        Console.WriteLine($"Log custom exception: {exception.Message}");
    }
}
