internal class CoffeeFactory
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