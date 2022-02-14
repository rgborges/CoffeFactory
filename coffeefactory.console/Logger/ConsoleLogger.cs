public class ConsoleLogger
{
    public void Log(string message, LoggerMessageType type)
    {
        Display.PrintLog(message, type);
    }

}