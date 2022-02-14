var logger = new ConsoleLogger();
var CoffeeMachine = new CoffeeMachine();
logger.Log($"Starting a new coffee in the coffee machine, wait a moment..", LoggerMessageType.Info);
var cupOfCoffee = await CoffeeMachine.MakeCoffeeAsync(new CapucchinoCoffee(), 250);
logger.Log($"{cupOfCoffee.ToString()}", LoggerMessageType.Info);

logger.Log($"Starting a new coffee in the coffee machine, wait a moment..", LoggerMessageType.Info);
var cupOfCoffee1 = await CoffeeMachine.MakeCoffeeAsync(new ExpressCoffee(), 250);
logger.Log($"{cupOfCoffee1.ToString()}", LoggerMessageType.Info);