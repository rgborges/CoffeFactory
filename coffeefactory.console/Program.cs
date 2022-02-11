var coffeeMachine = new CoffeeMachine();

var task1 = coffeeMachine.MakeCoffeeAsync(new CapucchinoCoffee(), 250);

var cup = await task1;
Console.WriteLine(cup.ToString());
Console.WriteLine("Coffee is ready!");



var task2 = coffeeMachine.MakeCoffeeAsync(new ExpressCoffee(), 250);

var cup2 = await task2;
Console.WriteLine(cup2.ToString());
Console.WriteLine("Coffee is ready!");