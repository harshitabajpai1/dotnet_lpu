using System;
namespace Day4OopDemo;
class Manager : Employee
{
    public int managerID{get; set;}
    public int insentive{get; set;}

    public new int CalculateSalary(int sal)
    {
        int mySal = 0;
        mySal = sal + 15000 + 3000 + 1500 - 2500;
        return mySal;
    }
}