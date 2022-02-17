internal class CoffeeService
{
    /// <summary>
    /// This is the list of orders receiveid by this service
    /// </summary>
    private Queue<CoffeeItem> orders;

    public CoffeeService()
    {
        orders = new Queue<CoffeeItem>();
    }
    public void RequestNewCoffee(CoffeeItem incomeItem)
    {
        orders.Enqueue(incomeItem);
    }
}