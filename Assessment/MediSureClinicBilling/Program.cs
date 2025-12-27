// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using MediSureClinicBilling;
Billing bill = new Billing();
bool flag = true;
while (flag)
{
    Console.WriteLine("============= MediSure Clinic Billing ==============");
    Console.WriteLine("1. Create New Bill");
    Console.WriteLine("2. View Last Bill");
    Console.WriteLine("3. Clear Last Bill");
    Console.WriteLine("4. Exit");
    Console.Write("Enter your option: ");
    int choice = Int32.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            {
                bill.CreateBill();
                break;
            }
        case 2:
            {
                bill.viewBill();
                break;
            }
        case 3:
            {
                bill.ClearLastBill();
                break;
            }
        case 4:
            {
                flag = false;
                Console.WriteLine("Thank you. Application closed normally.");
                break;
            }
        default:
            {
                Console.WriteLine("Invalid Choice");
                break;
            }              
    }
}












