public static class Display
{
    public static void PrintLog(string message, LoggerMessageType type)
    {
        if(type == LoggerMessageType.Info)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{DateTime.Now}: ");
            Console.Write(message);
            Console.WriteLine(" [INFO]");
        }
        
    }
}