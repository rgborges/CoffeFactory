internal class CoffeeItem : SellItem, IOrder
{
    private Guid guid;
    /// <summary>
    /// Coffee here is abstract. So you will receive the type by this varible.
    /// </summary>
    private Coffee? coffee;
    private OrderStatus status;
    private int volume;

    public Coffee Coffee { get => coffee; } 
    public double Price { get => price;}
    public int Volume { get => volume;}

    public CoffeeItem(Coffee coffee, double price, int volume)
    {
        guid = Guid.NewGuid();
        this.coffee = coffee;
        this.price = price;
        this.status = OrderStatus.Initiated;
        this.volume = volume;
    }

    public void ChangeOrderState(OrderStatus status)
    {
        this.status = status;
    }

    public Guid GetOrderId()
    {
        return this.guid;
    }
    public override string ToString()
    {
        if(coffee is null)
            throw new NullReferenceException("Coffee in this order is null");
        return $"Id: {guid.ToString()}, coffee: {coffee.ToString()}, price: {price}, status: {status}";
    }
}