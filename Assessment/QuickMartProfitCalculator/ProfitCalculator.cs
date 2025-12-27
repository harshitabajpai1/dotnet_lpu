using System;

namespace QuickMart
{
    class ProfitCalculator
    {
        static SaleTransaction LastTransaction;
        static bool HasLast = false;

        public void Create()
        {
            SaleTransaction transaction = new SaleTransaction();

            Console.Write("Enter Invoice No: ");
            transaction.InvoiceNo = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(transaction.InvoiceNo))
            {
                Console.WriteLine("Invoice number can not be empty");
                return;
            }

            Console.Write("Enter Customer Name: ");
            transaction.CustomerName = Console.ReadLine();

            Console.Write("Enter Item Name: ");
            transaction.ItemName = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            transaction.Quantity = int.Parse(Console.ReadLine());
            if (transaction.Quantity <= 0)
            {
                Console.WriteLine("Quantity must be greater than 0");
                return;
            }

            Console.Write("Enter Purchase Amount (total): ");
            transaction.PurchaseAmount = decimal.Parse(Console.ReadLine());
            if (transaction.PurchaseAmount <= 0)
            {
                Console.WriteLine("Purchase amount must be greater than 0");
                return;
            }

            Console.Write("Enter Selling Amount (total): ");
            transaction.SellingAmount = decimal.Parse(Console.ReadLine());
            if (transaction.SellingAmount < 0)
            {
                Console.WriteLine("Selling amount cannot be negative");
                return;
            }

            // Profit and loss calculation
            if (transaction.SellingAmount > transaction.PurchaseAmount)
            {
                transaction.ProfitOrLossStatus = "PROFIT";
                transaction.ProfitOrLossAmount = transaction.SellingAmount - transaction.PurchaseAmount;
            }
            else if (transaction.SellingAmount < transaction.PurchaseAmount)
            {
                transaction.ProfitOrLossStatus = "LOSS";
                transaction.ProfitOrLossAmount =transaction.PurchaseAmount - transaction.SellingAmount;
            }
            else
            {
                transaction.ProfitOrLossStatus = "BREAK-EVEN";
                transaction.ProfitOrLossAmount = 0;
            }

            transaction.ProfitMarginPercent =transaction.ProfitOrLossAmount / transaction.PurchaseAmount * 100;

            LastTransaction= transaction;
            HasLast = true;

            Console.WriteLine("\nTransaction Saved Successfully");
            Console.WriteLine("Status: " + transaction.ProfitOrLossStatus);
            Console.WriteLine("Profit/Loss Amount: " + transaction.ProfitOrLossAmount);
            Console.WriteLine("Profit Margin (%): " + transaction.ProfitMarginPercent);
        }

        public void View()
        {
            if (!HasLast)
            {
                Console.WriteLine("No transaction available");
                return;
            }

            Console.WriteLine("------ Last Transaction ------");
            Console.WriteLine("Invoice No: " + LastTransaction.InvoiceNo);
            Console.WriteLine("Customer: " + LastTransaction.CustomerName);
            Console.WriteLine("Item: " + LastTransaction.ItemName);
            Console.WriteLine("Quantity: " + LastTransaction.Quantity);
            Console.WriteLine("Purchase Amount: " + LastTransaction.PurchaseAmount);
            Console.WriteLine("Selling Amount: " + LastTransaction.SellingAmount);
            Console.WriteLine("Status: " + LastTransaction.ProfitOrLossStatus);
            Console.WriteLine("Profit/Loss Amount: " + LastTransaction.ProfitOrLossAmount);
            Console.WriteLine("Profit Margin (%): " + LastTransaction.ProfitMarginPercent);
            Console.WriteLine("-------------------------------");
        }

        public void CalculateProfitLoss()
        {
            if (!HasLast)
            {
                Console.WriteLine("No transaction available. Please create one first.");
                return;
            }
            LastTransaction.ProfitOrLossAmount = LastTransaction.SellingAmount - LastTransaction.PurchaseAmount;
 

            Console.WriteLine("------ Profit / Loss Result ------");

            if (LastTransaction.ProfitOrLossAmount > 0)
            {
                Console.WriteLine("Profit Amount: "+LastTransaction.ProfitOrLossAmount);
            }
            else if(LastTransaction.ProfitOrLossAmount < 0)
            {
                Console.WriteLine("Loss Amount: "+LastTransaction.ProfitOrLossAmount);
            }
            else
            {
                Console.WriteLine("No Profit No Loss");
            }
    
 

    }
}
}
