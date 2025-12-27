using System;

using QuickMart;
ProfitCalculator calculator = new ProfitCalculator();
int choice;
bool flag = true;
while (flag)
{
    Console.WriteLine("===== QuickMart Menu =====");
    Console.WriteLine("1. Create Transaction");
    Console.WriteLine("2. View Last Transaction");
    Console.WriteLine("3. Exit");
    Console.Write("Enter your choice: ");

    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            calculator.Create();
            break;

        case 2:
            calculator.View();
            break;
        case 3:
            {
                calculator.CalculateProfitLoss();
                break;
            }


        case 4:
            flag = false;
            Console.WriteLine("Thank you!");
            break;

        default:
        Console.WriteLine("Invalid choice");
        break;
        }

}







