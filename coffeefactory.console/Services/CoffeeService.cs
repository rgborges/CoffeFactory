internal class CoffeeService : ICoffeeService
{
    /// <summary>
    /// This delegate defines a function model to a function which receives a new Coffee type and returns a Cup.
    /// </summary>
    /// <param name="coffee"></param>
    /// <returns></returns>
    internal delegate void ProcessCoffee();
    internal event ProcessCoffee? eProcessCoffee;
    /// <summary>
    /// Input list for coffee orders itens.
    /// </summary>
    private List<CoffeeItem> coffeeItemList;
    /// <summary>
    /// Output list for cups filled by coffee.
    /// </summary>
    private List<Cup> processedCupList;
    public Queue<CoffeeItem> Orders { get => orders; } 
    /// <summary>
    /// This is the list of orders receiveid by this service
    /// </summary>
    private Queue<CoffeeItem> orders;
    private CoffeeMachine? coffeeFactory;
    public CoffeeService()
    {
        orders = new Queue<CoffeeItem>();
        coffeeItemList = new List<CoffeeItem>();
        coffeeFactory = new CoffeeMachine();
        processedCupList = new List<Cup>();
    }
    /// <summary>
    /// Adds a new coffee item request into the production queue
    /// </summary>
    /// <param name="incomeItem"></param>
    public void RequestNewCoffee(CoffeeItem incomeItem)
    {
        ///Adds a new item to a internal list. This lsit will keep tracking of the items
        ///requested from clients/agents.
        coffeeItemList.Add(incomeItem);
        //Put the coffee in the queue to be processed
        orders.Enqueue(incomeItem);
        //Invoke a new event
        eProcessCoffee?.Invoke();
    }
    public void SetNewProcessedCoffee(Cup cupOfCoffee)
    {
        this.processedCupList.Add(cupOfCoffee);
    }
    public List<CoffeeItem> GetPendingOrders()
    {
        return orders.ToList();
    }
    public List<Cup> GetProcessedCoffees()
    {
        return processedCupList ?? new List<Cup>();
    }
}