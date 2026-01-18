//Calculate numbers
using System;
using System.Collections.Generic;

class Program
{
    public static List<int> NumberList = new List<int>();

    //Add number to list
    public static void AddNumbers(int number)
    {
        NumberList.Add(number);
    }

    //Calculate GPA
    public static double GetGPAScore()
    {
        if (NumberList.Count == 0)
            return -1;

        int sum = 0;
        foreach (int num in NumberList)
        {
            sum += num * 3;
        }

        double gpa = (double)sum / (NumberList.Count * 3);
        return gpa;
    }

    //Get Grade
    public static char GetGradeScore(double gpa)
    {
        if (gpa == 10)
            return 'S';
        else if (gpa >= 9)
            return 'A';
        else if (gpa >= 8)
            return 'B';
        else if (gpa >= 7)
            return 'C';
        else if (gpa >= 6)
            return 'D';
        else if (gpa >= 5)
            return 'E';
        else
            return '\0';   //returning null
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of values:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            AddNumbers(num);
        }

        double gpa = GetGPAScore();

        if (gpa == -1)
        {
            Console.WriteLine("No Numbers Available");
            return;
        }

        char grade = GetGradeScore(gpa);

        if (grade == '\0')
        {
            Console.WriteLine("Invalid GPA");
        }
        else
        {
            Console.WriteLine("GPA: " + gpa);
            Console.WriteLine("Grade: " + grade);
        }
    }
}
