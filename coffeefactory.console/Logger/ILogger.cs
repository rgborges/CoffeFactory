public enum LoggerMessageType
{
    Info,
    Debug,
    Warning,
    Error
}
public interface ILogger
{
    public void Log(string message, LoggerMessageType type);
    public Task LogAsync(string message, LoggerMessageType type);
}