namespace Adapter;

public interface ILogger
{
    void Log(string message);

    void LogException(Exception exception);
}
