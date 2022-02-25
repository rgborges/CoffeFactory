internal interface ICoffeeService 
{
    internal List<CoffeeItem> GetPendingOrders();
    internal void RequestNewCoffee(CoffeeItem item);
    internal List<Cup> GetProcessedCoffees();
    Task RequestNewCoffeeAsync(CoffeeItem order);
}