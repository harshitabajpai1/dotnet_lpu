using System;

namespace EmployeeSystem
{
    public class Employee
    {
        public static void Main()
        {
            Console.Write("Enter Employee ID: ");
            int empId = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            string Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            //  Age Validation
            if (age < 21)
            {
                Console.WriteLine("Employee is not eligible to work");
                return;
            }

            Console.WriteLine("Select Department:");
            Console.WriteLine("1. IT");
            Console.WriteLine("2. HR");
            Console.WriteLine("3. Finance");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter Basic Salary: ");
            double basicSal = double.Parse(Console.ReadLine());

            string department = "";
            string role = "";
            double allowance = 0;

            
            switch (choice)
            {
                case 1:
                    department = "IT";
                    Console.WriteLine("Select Role: 1. Developer snd  2. Tester");
                    int itRole = int.Parse(Console.ReadLine());

                    switch (itRole)
                    {
                        case 1:
                            role = "Developer";
                            allowance = 30;
                            break;
                        case 2:
                            role = "Tester";
                            allowance = 25;
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            return;
                    }
                    break;

                case 2:
                    department = "HR";
                    Console.WriteLine("Select Role: 1. Recruiter snd 2. Payroll");
                    int hrRole = int.Parse(Console.ReadLine());

                    switch (hrRole)
                    {
                        case 1:
                            role = "Recruiter";
                            allowance = 20;
                            break;
                        case 2:
                            role = "Payroll";
                            allowance = 22;
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            return;
                    }
                    break;

                case 3:
                    department = "Finance";
                    Console.WriteLine("Select Role: 1. Accountant and 2. Auditor");
                    int finRole = int.Parse(Console.ReadLine());

                    switch (finRole)
                    {
                        case 1:
                            role = "Accountant";
                            allowance = 28;
                            break;
                        case 2:
                            role = "Auditor";
                            allowance = 26;
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            return;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid");
                    return;
            }

            //salary calculation
            double finalSal = basicSal + (basicSal * allowance / 100);

            
            string access;

            if (finalSal>= 60000 && department == "IT")
                access = "Admin Access";
            else if (finalSal >= 60000)
                access = "Manager Access";
            else
                access = "Employee Access";

            
            Console.WriteLine("--- Employee Details ---");
            Console.WriteLine($"Employee ID     : {empId}");
            Console.WriteLine($"Employee Name   : {Name}");
            Console.WriteLine($"Department      : {department}");
            Console.WriteLine($"Role            : {role}");
            Console.WriteLine($"Basic Salary    : {basicSal}");
            Console.WriteLine($"Final Salary    : {finalSal}");
            Console.WriteLine($"Access Level    : {access}");
        }
    }
}
