class OrderManager
{
    List<Order> OrderList = null;
    public OrderManager(){
        OrderList = new List<Order>();
        
    }
    public void AddOrder(Order order)
    {
        if(order.Amount <= 0)
        {
            throw new InvalidOrderException("Invalid Order detaials");
        }
        OrderList.Add(order);
    }
    public List<Order> GetHighValueOrders(decimal minAmount)
    {
        // List<Order> result  = new List<Order>();
        var highValueOrders = OrderList.Where( p=>p.CalculateFinalAmount() > minAmount).OrderByDescending(p =>p.Amount);
        return highValueOrders.ToList();

    }
}