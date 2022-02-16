internal enum CoffeeMachineState
{
    Initilized,
    ReadyToStart,
    Started,
    Filling,
    Finished
}

internal class CoffeeMachine 
{
    public delegate void ReportChange(string message);
    public event ReportChange? eReportChanged;
    /// <summary>
    /// A coffee machine interacts with a cup and makes coffee inside the machine. In this example, at first 
    /// we expect that a coffee machine interacts with a cup.
    /// Expected woorkflow:
    /// </summary>
    /// <summary>
    /// Coffee Factory class need to be set in order to produce different types of coffee
    /// </summary>
    private ICoffeeFacotry? _coffeeFactory;
   /// <summary>
   /// This container represents a cup within the coffee machine
   /// </summary>
    private Cup? _cupInput;
   /// <summary>
   /// Represents the current state of this machine
   /// </summary>
    private CoffeeMachineState _state;

    public CoffeeMachineState State { get => _state;  }
    public Cup? Cup { get => _cupInput; }
    public CoffeeMachine() {}
    public CoffeeMachine(ICoffeeFacotry? factory)
   {
       if(factory is null) throw new NullReferenceException();

       this._coffeeFactory = factory;
       this._state = CoffeeMachineState.Initilized;
   }
    public void SetCup(ref Cup cup)
   {
       this._cupInput = cup;
       this._state = CoffeeMachineState.ReadyToStart;
   }

   /// <summary>
   /// Sycronous task for make coffee. The coffe machine states will be changed.
   /// </summary>
   /// <param name="coffee"></param>
    public void MakeCoffee(Coffee coffee)
   {
       if(_cupInput is null || eReportChanged is null) throw new NullReferenceException();
       this._state = CoffeeMachineState.Filling;
       this.eReportChanged($"Coffee Machine state changed to Filling for {coffee.ToString()}");
       this._cupInput.Fill(coffee);
       this._state = CoffeeMachineState.Finished;
       this.eReportChanged($"Coffee Machine state changed to Finished for {coffee.ToString()}");
    }
    public async Task<Cup> MakeCoffeeAsync(Coffee coffee, int volume)
    {
        if(eReportChanged is null) throw new NullReferenceException("The delegate function assigned to CoffeeMachine event is null");
        this.eReportChanged($"Initiating machine to a new coffee {coffee.ToString()}");
        Cup cup = new Cup(volume);
        this._state = CoffeeMachineState.Filling;
        this.eReportChanged($"Coffee Machine state changed to Filling for {coffee.ToString()}");
        cup.Fill(coffee);
        await Task.Delay(3000);
        this._state = CoffeeMachineState.Finished;
        this.eReportChanged($"Coffee Machine state changed to Finished for {coffee.ToString()}");
        return cup;
    }
}