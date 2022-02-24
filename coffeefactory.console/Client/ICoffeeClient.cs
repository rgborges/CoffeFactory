internal interface ICoffeeClient
{
    /// <summary>
    /// Requests a new cappuccino coffee to the service with a specified cup volume. The method returns a 
    /// coffee order.
    /// </summary>
    /// <param name="cupVolume"></param>
    /// <returns></returns>
    CoffeeItem RequestCappuccinoCoffee(int cupVolume);
    List<CoffeeItem> GetPendingOrders();
    List<Cup> GetProcessedCoffees();
}