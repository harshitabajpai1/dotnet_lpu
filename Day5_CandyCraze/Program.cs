using System;
using CandyCraze;
public class Program
{
    // Method to calculate discounted price
    public Candy CalculateDiscountedPrice(Candy candy)
    {
        candy.TotalPrice = candy.Quantity * candy.PricePerPiece;

        double discountPercentage = 0;

        if (candy.Flavour == "Strawberry")
            discountPercentage = 15;
        else if (candy.Flavour == "Lemon")
            discountPercentage = 10;
        else if (candy.Flavour == "Mint")
            discountPercentage = 5;

        candy.Discount = candy.TotalPrice -  (candy.TotalPrice * discountPercentage / 100);

        return candy;
    }

    public static void Main(string[] args)
    {
        Candy candy = new Candy();
        Program program = new Program();

        Console.WriteLine("Enter the flavour");
        candy.Flavour = Console.ReadLine();

        Console.WriteLine("Enter the quantity");
        candy.Quantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the price per piece");
        candy.PricePerPiece = Convert.ToInt32(Console.ReadLine());

        if (candy.validateCandyFlavour())
        {
            candy = program.CalculateDiscountedPrice(candy);

            Console.WriteLine("Flavour : " + candy.Flavour);
            Console.WriteLine("Quantity : " + candy.Quantity);
            Console.WriteLine("Price Per Piece : " + candy.PricePerPiece);
            Console.WriteLine("Total Price : " + candy.TotalPrice);
            Console.WriteLine("Discount Price : " + candy.Discount);
        }
        else
        {
            Console.WriteLine("Invalid flavour");
        }
    }
}