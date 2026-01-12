// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Security.Cryptography;

namespace LINQ_ConsoleApp
{
    class Program
    {
        public static void LinqToObjectDemoOnCustomTypes()
        {
            List<Customer> custList = new List<Customer>()
            {
                new Customer(){CustomerId =101,Name = "Harshita",City ="Raebreli"},
                new Customer{CustomerId =102,Name = "Himanshi",City ="haldwani" },
                new Customer(){CustomerId =103,Name = "Ayush",City ="Ahemdabad"},
                new Customer(){CustomerId =104,Name = "Dheeraj",City ="Lucknow"},
                new Customer(){CustomerId =105,Name = "Shaheer",City ="Jammu"},
                new Customer(){CustomerId =106,Name = "Anaya",City ="Pune"},
                new Customer(){CustomerId =107,Name = "Kudrat",City ="Mumbai"},
                new Customer(){CustomerId =108,Name = "Ruchika",City ="chennai"},

            };
            //Anonymous object
            //var data = new { OrderId = 1090, OrderDate = "12/01/2026", TotalAmount = 14000 };


            var result = custList.Where(cust => cust.City == "Pune"); // multiple occurance  use for link to sql 

            var result1 = custList.Find(cust => cust.City == "Lucknow"); // only first occurance

            //FINDALL shows all the matching records
            //in Linq sql find will work on primary key column only and return single record
            //where and findall can be used on any column and return multiple records

            //for showing the data
            foreach (var item in result)
            {
                Console.WriteLine($"CustomerId: {item.CustomerId}, Name: {item.Name}, City: {item.City}");

            }
        }
        public static void LinqToObjectDemo()
        {
            int[] numArray = {10,2,12,34,45,67,88,89,90 };
            string[] nameArray = { "John", "Jane", "Jack", "Doe", "Smith","Alok" };

            //using traditional approach
            //foreach (var item in numArray)
            //{
            //    if(item % 2 == 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            //using LINQ Query Syntax

            //int dataToSearch = 120;
            //Console.Write("Enter name to search: ");
            //string dataToSearch = Console.ReadLine();
            

            var result = from data in nameArray
                         //where data == dataToSearch
                         //where data.StartsWith("J")
                         //where data.Contains("a")  || data.Contains("A")
                         orderby data descending
                         select data;



            //method Syntax
            //var result = nameArray.Where(n => n == dataToSearch);   //it is a string data type

            //var result = from data in numArray
            //             where data == dataToSearch
            //             //where data % 2 == 0 && data >20
            //             select data;
            //result is varient type - IEnumerable<int>

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void LambdaLookUp()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };
            //var query = numbers.TOLookUp

        }

        public static void LambdaLookUpStudentList()
        {
            StudentRepo sRepo = new StudentRepo();
            List<Student> tempList = sRepo.GetAllStudents();
            var Query = tempList.ToLookup(s => s.Gender == "Male");
            foreach(IGrouping<bool,Student> group in Query)
            {
                int totalFees = 0;
                if(group.Key == true)
                {
                    Console.WriteLine("Male Student Details below.");
                }
                else
                {
                    Console.WriteLine("Female Student Details below.");
                }
                    //Console.WriteLine("Key : {0}", group.Key);
                foreach(Student std in group)
                {
                    Console.WriteLine($"{std.Name}");
                    totalFees += std.Fees;
                }
                Console.WriteLine("the total fees "+ totalFees);

            }
            //var maleFeesPaid = tempList.ToLookup(s => s.Gender = "Male").Sum();

        }
        static void Main(string[] args)
        {
            //LinqToObjectDemo();
            //LinqToObjectDemoOnCustomTypes();
            //LambdaLookUpStudentList();

            StudentRepo sRepo=new StudentRepo();
            List<Student> TempList = sRepo.GetAllStudents();
            var total = TempList.Select(s => s.Fees).Sum();
            var min = TempList.Select(s => s.Fees).Min();
            var max = TempList.Select(s => s.Fees ).Max();
            Console.WriteLine("Total fees : "+total);
            Console.WriteLine("Minimum fees: " + min);
            Console.WriteLine("Maximun fees: "+max);
        }
    }
}
