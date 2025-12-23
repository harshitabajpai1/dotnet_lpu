// See https://aka.ms/new-console-template for more information
using CakeShop;
Console.WriteLine("Hello, World!");
try
{
    Cake cake = new Cake();   // object of the class cake
    Console.Write("Enter cake flavour ");
    cake.Flavour = Console.ReadLine();
    Console.Write("Enter Quantity in Kg");
    cake.QuantityInKg = Int32.Parse(Console.ReadLine());
    Console.Write("Enter price per kg");
    cake.PricePerKg = Int32.Parse(Console.ReadLine());

    if (cake.cakeOrder())
    {
        Console.WriteLine("Cake order placed successfully");
        Console.WriteLine("The price of the cake after discount is "+cake.calculatePrice());
    }
}
catch (InvalidFlavourException e)
{
    Console.WriteLine(e.Message);
}
catch (InvalidQuantityException e)
{
    Console.WriteLine(e.Message);
}
