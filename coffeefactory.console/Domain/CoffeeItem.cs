internal class CoffeeItem : SellItem, IOrder
{
    private Guid guid;
    /// <summary>
    /// Coffee here is abstract. So you will receive the type by this varible.
    /// </summary>
    private Coffee? coffee;
    private OrderStatus status;

    public CoffeeItem(Coffee coffee, double price)
    {
        guid = Guid.NewGuid();
        this.coffee = coffee;
        this.price = price;
        this.status = OrderStatus.Initiated;
    }

    public void ChangeOrderState(OrderStatus status)
    {
        this.status = status;
    }

    public Guid GetOrderId()
    {
        return this.guid;
    }
}