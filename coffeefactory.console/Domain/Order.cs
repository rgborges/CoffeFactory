internal interface IOrder
{
    Guid GetOrderId();
    void ChangeOrderState(OrderStatus status);
}