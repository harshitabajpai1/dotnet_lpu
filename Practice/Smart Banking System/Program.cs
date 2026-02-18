// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main()
    {
        BankUtility bank = new BankUtility();

        try
        {
            bank.AddAccount(new SavingAccount(1, "Rahul", 60000));
            bank.AddAccount(new CurrentAccount(2, "Riya", 30000));
            bank.AddAccount(new LoanAccount(3, "Amit", 100000));
            bank.AddAccount(new SavingAccount(4, "Rohan", 80000));

            Console.WriteLine("Total Bank Balance: " + bank.GetTotalBalance());

            Console.WriteLine("\nAccounts > 50,000:");
            foreach (var acc in bank.AccountWithMoreBalance())
                Console.WriteLine(acc.CustomerName + " - " + acc.Balance);

            Console.WriteLine("\nTop 3 Accounts:");
            foreach (var acc in bank.GetTop3HighestBalanceAccount())
                Console.WriteLine(acc.CustomerName + " - " + acc.Balance);

            Console.WriteLine("\nCustomers starting with R:");
            foreach (var name in bank.CustomerNameStartsWithR())
                Console.WriteLine(name);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
