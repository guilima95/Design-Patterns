namespace Adapter;

public interface ILoggerCustom
{
    void Log(string message);

    void LogException(Exception exception);
}
