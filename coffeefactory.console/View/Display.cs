public static class Display
{
    internal static void Print(string message)
    {
        Console.WriteLine(message);
    }
    internal static void PrintLog(string message, LoggerMessageType type)
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

    internal static void PrintHeader()
    {
        Console.Write("coffee backery >> ");
    }

    internal static void PrintWaitMessage()
    {
       Console.Write("Press any key to generate a new Coffee...");
    }
    internal static void NewCoffeeRequested()
    {
        System.Console.WriteLine("new coffee requested");
    }

    internal static void PrintHelp()
    {
        System.Console.WriteLine("Command                   | Descripition");
        System.Console.WriteLine("--------------------------+--------------------------------------------------------------------------------------");
        System.Console.WriteLine("new coffee                | Request a new coffe to the system. Use -t c for cappuccino and -t e for express.");
        System.Console.WriteLine("new check                 | Check information from the client."); 
        System.Console.WriteLine("--------------------------+--------------------------------------------------------------------------------------");
        System.Console.WriteLine("Examples: ");
        System.Console.WriteLine("new coffee -t c      : Request a new cappuccino coffee.");
        System.Console.WriteLine("check pending-orders : Check pending orders from the service.");
        System.Console.WriteLine("check ready-coffees  : Check the coffess processed.");

    }
    internal static void PrintLogo()
    {
        System.Console.WriteLine("");
        System.Console.WriteLine("                           )))))");
        System.Console.WriteLine("                         )))))");
        System.Console.WriteLine("                    ((((");
        System.Console.WriteLine("                   ((((");
        System.Console.WriteLine("        (@!#!#!#!@!@!@!#@#!@#!@#)rererer");
        System.Console.WriteLine("        (@!#!#!#!@!@!@!#@#!@#!@#)rererer");
        System.Console.WriteLine("         (g!@!@!@@!@!@#!@#!@#fh)r/   /sd");
        System.Console.WriteLine("          we!#!#@!@#!@#!wef7o)re/    /df");
        System.Console.WriteLine("           re#!#!@#!#!#wefoerer/    /vv");
        System.Console.WriteLine("            ewrrerdsfgdfggdgfdfvv/");
        System.Console.WriteLine("              rewrererdgdfgvbl");
        System.Console.WriteLine("                                           ");
        System.Console.WriteLine("            COFFEE FACTORY PROJECT          ");
    }

    internal static void PrintPendingOrders(List<CoffeeItem> coffeeItems)
    {
        foreach (CoffeeItem item in coffeeItems)
        {
            Console.WriteLine(item.ToString());
        }
    }

    internal static void RequestedDone(CoffeeItem temp)
    {
        Display.PrintLog($"New coffee order requested to the service: \n {temp.ToString()}", LoggerMessageType.Info);
    }

    internal static void PrintReadyCoffees(List<Cup> cups)
    {
        foreach(Cup cup in cups)
        {
            Console.WriteLine(cup.ToString());
        }
    }
}