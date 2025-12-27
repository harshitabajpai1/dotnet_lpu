using System;
namespace CandyCraze
{
    public class Candy
    {
        public string Flavour{get;set;}
        public int Quantity{get;set;}
        public  int PricePerPiece{get;set;}
        public double TotalPrice{get;set;}
        public double Discount{get;set;}

        public bool validateCandyFlavour()
        {
            if(Flavour == "Mint" || Flavour =="Lemon" || Flavour == "Strawberry")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}