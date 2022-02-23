internal class ConsoleCli
{
    private CoffeeItem _temp;
    private List<Task>  worker;
    private readonly ICoffeeClient client;
    private readonly string[] args;
    //new coffee -t c //asks for a couppuchino coffee
    //new coffee -t e //asks for a express coffee
    //check order -i <guid>
    //check order -a //List all orders
    public ConsoleCli(ICoffeeClient client)
    {
        if (client is null)
         throw new NullReferenceException("The CoffeeClient object passed to the cli is null.");
        this.client = client;
        this.worker = new List<Task>();
    }
    public async Task Run(string[] args)
    {
        switch(args[0])
        {
            case "new":
                switch(args[1])
                {
                    case "coffee":
                        switch(args[2])
                        {
                            case "-t":
                                switch(args[3])
                                {
                                    case "c":
                                        //Make a new cappuchino coffee
                                        if(args.Length == 4)
                                        {
                                            _temp = client.RequestCappuccinoCoffee(250);
                                            Display.RequestedDone(_temp);
                                            break;
                                        }
                                        switch (args[4])
                                        {
                                            case "-v":

                                            break;
                                        }
                                     
                                    break;
                                    case "e":
                                        //Make a new express coffee
                                        System.Console.WriteLine("Make a new express coffee");
                                    break;
                                }
                            break;
                        }
                    break;
                }
            break;
            case "check":
                switch(args[1])
                {
                    case "pending-orders":
                        try
                        {
                            Display.PrintPendingOrders(client.GetPendingOrders());
                        }
                        catch (Exception e)
                        {
                            
                        }
                    break;
                }
            break;
            case "--help":
                Display.PrintHelp();
            break;
        }
    }
}