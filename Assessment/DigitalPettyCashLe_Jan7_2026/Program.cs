// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using DigitalPettyCashLe;
class Program
{
    static void Main(String[] args)
    {
        Ledger<IncomeTransaction> income = new Ledger<IncomeTransaction>();
        Ledger<ExpenseTransaction> expence = new Ledger<ExpenseTransaction>();

        Console.WriteLine("Enter the your income");
        int amount = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Enter the income source");
        string source = Console.ReadLine();


        //Adding tht traction to income ledger
        income.AddEntry(new IncomeTransaction
        {
            ID = 101,
            Date = DateTime.Today,
            Amount = amount,
            
            Description = "description for digital petty cash le",
            Source = source

        });

        //Adding the the daily expences 
        //user can add n number of transations  daily to keep record and summary of it
        // Console.Write("Enter the number of transaction details you want to enter")
        bool exit  = false;
        int i = 1;
        while (!exit)
        {
            
            Console.Write("Amount: ");
            int expenseAmount = int.Parse(Console.ReadLine());

            Console.Write("Category: ");
            string category = Console.ReadLine();

            Console.Write("Description: ");
            string desc = Console.ReadLine();

            expence.AddEntry(new ExpenseTransaction
            {
                ID = i,
                Date = DateTime.Today,
                Amount = expenseAmount,
                Description = desc,
                Category = category
            });
            i++;

            Console.WriteLine("Want to add more transaction or exit the application");
            Console.Write("Enter X to exit and  any other key to coninue");
            string choice = Console.ReadLine();
            if(choice == "X" | choice == "x")
            {
                exit = true;
                Console.WriteLine("All transaction Added");
            }
            else
            {
                continue;
            }
        }

        int totalIncome = income.CalculateTotal();
        int totalExpense = expence.CalculateTotal();
        int netBalance = totalIncome - totalExpense;

        Console.WriteLine(" PETTY CASH REPORT");
        Console.WriteLine($"Total Income  : {totalIncome}");
        Console.WriteLine($"Total Expense : {totalExpense}");
        Console.WriteLine($"Net Balance   : {netBalance}");

        
    }
}
