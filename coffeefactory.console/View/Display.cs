public static class Display
{
    public static void Print(string message)
    {
        Console.WriteLine(message);
    }
    public static void PrintLog(string message, LoggerMessageType type)
    {
        if(type == LoggerMessageType.Info)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"{DateTime.Now}: ");
            Console.Write(message);
            Console.WriteLine(" [INFO]");
        }
        else if(type == LoggerMessageType.Warning)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"{DateTime.Now}: ");
            Console.Write(message);
            Console.WriteLine(" [WARN]");
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }

    internal static void PrintWaitMessage()
    {
       Console.Write("Press any key to generate a new Coffee...");
    }
    internal static void NewCoffeeRequested()
    {
        System.Console.WriteLine("new coffee requested");
    }
}