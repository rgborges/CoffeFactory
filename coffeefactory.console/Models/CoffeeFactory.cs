internal class CoffeeFactory : ICoffeeFacotry
{
    public CoffeeFactory() { }
    public ExpressCoffee CreateExpressCoffee()
    {
      return new ExpressCoffee();
    }
    public CapucchinoCoffee CreateCappuchinoCoffee()
    {
      return new CapucchinoCoffee();   
    }
}