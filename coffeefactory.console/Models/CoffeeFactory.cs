internal class CoffeeFactory : ICoffeeFacotry
{
    public CoffeeFactory() { }
    public ExpressCoffee CreateExpressCoffee()
    {
      return new ExpressCoffee();
    }
    public CappuccinoCoffee CreateCappuchinoCoffee()
    {
      return new CappuccinoCoffee();   
    }
}