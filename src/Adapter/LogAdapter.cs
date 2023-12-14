namespace Adapter;

// Adapter Class: 
// adapts the interface Adaptee to the Target interface.
public class LogAdapter(ILoggerCustom loggerCustom) : ILogger
{
    private readonly ILoggerCustom _loggerCustom = loggerCustom;

    public void Log(string message)
    {
        _loggerCustom.Log(message);
    }

    public void LogException(Exception exception)
    {
        _loggerCustom.LogException(exception);
    }
}
