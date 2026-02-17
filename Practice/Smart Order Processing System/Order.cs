enum OrderStatus
{
    Pending,
    shipped,
    Delivered,
    Cancelled
}
abstract class Order
{
    //Auto Implicit properties
    public int OrderId{get;set;}
    public string CustomerName{get; set;}
    public decimal Amount {get; set;}
    public OrderStatus Status {get; set;}

    public Order(int id, string name, decimal amount)
    {
        OrderId = id;
        CustomerName = name;
        Status = OrderStatus.Pending;
        Amount = amount;
    }

    public abstract decimal CalculateFinalAmount();

}