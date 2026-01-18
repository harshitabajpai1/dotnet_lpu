//E commerce website
using System;

//EcommerceShop class
class EcommerceShop
{
    public string UserName { get; set; }
    public double WalletBalance { get; set; }
    public double TotalPurchaseAmount { get; set; }
}

//Custom Exception
class InsufficientWalletBalanceException : Exception
{
    public InsufficientWalletBalanceException(string message) : base(message)
    {
    }
}

class Program
{
    // MakePayment method
    public static EcommerceShop MakePayment(string name, double balance, double amount)
    {
        if (balance < amount)
        {
            throw new InsufficientWalletBalanceException(
                "Insufficient balance in your digital wallet"
            );
        }

        EcommerceShop shop = new EcommerceShop();
        shop.UserName = name;
        shop.WalletBalance = balance;
        shop.TotalPurchaseAmount = amount;

        return shop;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter User Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Wallet Balance:");
            double balance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Purchase Amount:");
            double amount = double.Parse(Console.ReadLine());

            EcommerceShop result = MakePayment(name, balance, amount);

            if (result != null)
            {
                Console.WriteLine("Payment successful");
            }
        }
        catch (InsufficientWalletBalanceException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
