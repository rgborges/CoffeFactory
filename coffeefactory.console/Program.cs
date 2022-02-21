using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
   static async Task Main(string[] args)
   {
       var coffeeMachine = new CoffeeMachine();
       var item = new CoffeeItem(new CappuccinoCoffee(), 12.90, 250);
       var service = new CoffeeService();
       var logger = new FileLogger();
       var worker = new CoffeeProcessorWorker(service, coffeeMachine, logger);
       coffeeMachine.eReportChanged += CoffeMachineReport;

       while(true)
       {
          try
          {
            Display.PrintWaitMessage();
            //var a = Console.ReadLine();
            service.RequestNewCoffee(item);
            Display.Print("New coffee requested!");
            Thread.Sleep(1000);
          }
          catch(Exception e)
          {
             Display.Print(e.Message);
          }
          
       }
   }
   private static void CoffeMachineReport(string m)
   {
      Display.PrintLog(m, LoggerMessageType.Info);
   }       
}