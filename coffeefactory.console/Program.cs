using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
   static async Task Main(string[] args)
   {
      var service = new CoffeeService();
      var client = new CoffeeMemoryClient(service);
      var cli = new ConsoleCli(client);
      var factory = new CoffeeMachine();
      var logger = new FileLogger();
      var worker = new CoffeeProcessorWorker(service, factory, logger);
      worker.isEnable = true;
       try
       {
         Display.PrintLogo();
         while(true)
         {
            
            Display.PrintHeader();
            await cli.Run(Console.ReadLine().Split(' '));
            
         }
       }
       catch (Exception e)
       {
          Display.PrintLog(e.Message, LoggerMessageType.Error);
       }
   }
   private static void CoffeMachineReport(string m)
   {
      Display.PrintLog(m, LoggerMessageType.Info);
   }       
}