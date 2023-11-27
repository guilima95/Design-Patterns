namespace Adapter;

// Adapter Class: 
// adapts the interface Adaptee to the Target interface.
public class LogAdapter : ILogger
{
    private readonly ILoggerCustom _loggerCustom;

    public LogAdapter(ILoggerCustom loggerCustom)
    {
        _loggerCustom = loggerCustom;
    }

    public void Log(string message)
    {
        _loggerCustom.Log(message);
    }

    public void LogException(Exception exception)
    {
        _loggerCustom.LogException(exception);
    }
}
