using System;
namespace CakeShop
{
    public class Cake
    {
        public string Flavour{get;set;}
        public int QuantityInKg{get;set;}
        public double PricePerKg{get;set;}

        public bool cakeOrder()
        {
            //validate the invalid flavour exception
            if(Flavour !="Vanilla"  && Flavour !="Chocolate" && Flavour != "Red Velvet")
            {
                throw new InvalidFlavourException();
            }

            // validate the Quantity Exception
            if(QuantityInKg <= 0)
            {
                throw new InvalidQuantityException();
            }

            return true;
        }

        public double calculatePrice()
        {
            double discount = 0;
            if(Flavour == "Vanilla")
            {
                discount = 3;
            }
            else if(Flavour == "Chocolate")
            {
                discount = 5;
            }
            else if(Flavour == "Red Velvet")
            {
                discount = 10;
            }
            double totalPrice = QuantityInKg * PricePerKg;
            double discountPrice = totalPrice - (totalPrice *discount/100);

            return discountPrice;
        }
    }

    public class InvalidFlavourException : Exception
    {
        public InvalidFlavourException() : base("The flavour in not available/ Invalid")
        {
            
        }
    }

    public class InvalidQuantityException : Exception
    {
        public InvalidQuantityException() : base("the Quantity is Invalid")
        {
            
        }
    }
}