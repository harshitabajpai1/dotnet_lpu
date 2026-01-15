// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ServiceLibrary;
using System;
namespace UILogic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.Write("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            SomeLogic logic = new SomeLogic();

            //visual studio gives the intelisense of the fucntion in the SomeLogic class 
            //is is clled design reflection as it is providing the meta data
            int result = logic.Add(num1, num2);

            Console.WriteLine($"the sum of {num1} and {num2} is {result}");

            Console.ReadLine();  //to Hold out


        }
    }
}