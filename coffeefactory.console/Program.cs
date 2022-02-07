// See https://aka.ms/new-console-template for more information
var factory = new CoffeeFactory();
var coffeeMachine = new CoffeeMachine(factory);
//Create a cup 250 ml
var cup = new Cup(250);

//Set the cup within the machine
coffeeMachine.SetCup(ref cup);

coffeeMachine.MakeCoffee(new CapucchinoCoffee());

//Get coffe
Console.WriteLine($"{cup.ToString()}");