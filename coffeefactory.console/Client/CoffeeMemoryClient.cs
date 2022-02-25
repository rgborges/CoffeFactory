internal class CoffeeMemoryClient : ICoffeeClient
{
    private readonly ICoffeeService service;
    public CoffeeMemoryClient(ICoffeeService service)
    {
        if (service is null)
         throw new NullReferenceException("service passed to CoffeeMemoryClient is null");
        this.service = service;
    }

    CoffeeItem ICoffeeClient.RequestCappuccinoCoffee(int cupVolume)
    {
        var order = new CoffeeItem(new CappuccinoCoffee(), 12.90, cupVolume);
        service.RequestNewCoffee(order);
        return order;
    }
    public List<CoffeeItem> GetPendingOrders()
    {
        return service.GetPendingOrders();
    }

    public List<Cup> GetProcessedCoffees()
    {
        return service.GetProcessedCoffees();
    }

    public Task RequestCappuccinoAsyncCoffee(int cupVolume)
    {
        var order = new CoffeeItem(new CappuccinoCoffee(), 12.90, cupVolume);
        var task = service.RequestNewCoffeeAsync(order);
        return task;
    }
       
}