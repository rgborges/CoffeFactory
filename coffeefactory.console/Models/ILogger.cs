public enum LoggerMessageType
{
    Info,
    Debug,
    Warning,
    Error
}
public interface ILogger
{
    public void Log(string mesage, LoggerMessageType type);
}