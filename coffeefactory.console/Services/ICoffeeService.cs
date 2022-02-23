internal interface ICoffeeService 
{
    internal List<CoffeeItem> GetPendingOrders();
    internal void RequestNewCoffee(CoffeeItem item);
}