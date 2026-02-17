// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
    static void Main()
    {
        OrderManager mgr = new OrderManager();

        try
        {
            mgr.AddOrder(new RegularOrder(101, "Alice", 500));
            mgr.AddOrder(new PremiumOrder(102, "Bob", 1000)); // Final value will be 1100
            
            // This will throw exception
            mgr.AddOrder(new RegularOrder(103, "Charlie", -50));

            var topOrders = mgr.GetHighValueOrders(800);

            Console.WriteLine("\n--- High Value Orders ---");
            foreach (var order in topOrders)
            {
                Console.WriteLine($"ID: {order.OrderId}, Final Amt: {order.CalculateFinalAmount()}");
            }
        }
        catch (InvalidOrderException ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
        }
    }
}

