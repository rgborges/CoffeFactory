internal class CoffeeProcessorWorker
{
    private CoffeeMachine factory;
    private CoffeeService? service;
    private ILogger logger;

    public CoffeeProcessorWorker(CoffeeService service, CoffeeMachine factory, ILogger logger)
    {
        this.factory = factory;
        this.service = service;
        service.eProcessCoffee += CoffeeWorker;
        factory.eReportChanged += this.LogMessage;
        this.logger = logger;

    }
    private async void CoffeeWorker()
    {
        if(service is null) throw new NullReferenceException();
        for (int i = 0; i < service.Orders.Count; i++)
        {
            var order = service.Orders.Dequeue();
            var cup = await factory.MakeCoffeeAsync(order.Coffee, order.Volume);
            if(service.processedCupList is not null)
            {
                service.processedCupList.Add(cup);
            }
            else
            {
                service.processedCupList = new List<Cup>();
            }
        }
    }
    private void LogMessage(string message)
    {
        logger.Log(message, LoggerMessageType.Info);
    }
}   