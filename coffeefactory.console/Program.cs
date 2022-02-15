using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
   static async Task Main(string[] args)
   {
        var logger = new ConsoleLogger();
        var CoffeeMachine = new CoffeeMachine();
        logger.Log($"Starting a new coffee in the coffee machine, wait a moment..", LoggerMessageType.Info);
        
        var task1 = CoffeeMachine.MakeCoffeeAsync(new CapucchinoCoffee(), 250);
        logger.Log($"Coffe 01 scheduled to being executed", LoggerMessageType.Info);
        
        var task2 = CoffeeMachine.MakeCoffeeAsync(new ExpressCoffee(), 250);
        logger.Log($"Coffe 02 scheduled to being executed", LoggerMessageType.Info);

        var coffe1 = await task1;
        logger.Log($"{coffe1.ToString()}", LoggerMessageType.Info);
        
        var coffe2 = await task2;
        logger.Log($"{coffe2.ToString()}", LoggerMessageType.Info);
   }       
}