using System;
namespace Day4OopDemo;
class Employee
{
    #region Fields
    public int employeeId{get;set;}
    public string name;
    public int BasicSal{get; set;}
    #endregion

    public int CalculateSalary(int sal)
    {
        int mySal = 0;
        mySal = sal + 15000+ 3000+ 1500 - 2500;
        return mySal;
    }
}