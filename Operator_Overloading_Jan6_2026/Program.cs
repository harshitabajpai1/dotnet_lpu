// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Employee emp1 = new Employee();
emp1.EmpID = 101;
emp1.EmpName = "Alok";
emp1.Salary = 40000;


Employee emp2 = new Employee();
emp2.EmpID = 104;
emp2.EmpName = "Aliya";
emp2.Salary = 50000;

Employee empObj = emp1+emp2;

Console.WriteLine($"total sal paid {empObj.Salary}");