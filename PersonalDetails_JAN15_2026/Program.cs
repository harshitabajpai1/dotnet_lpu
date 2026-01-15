// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using PersonDetails;
using System;
class Program
{
    static void  Main(String[] args)
    {
        IList<Person>  p = new List<Person>();
        p.Add(new Person{Name = "Harshita", Address = " A2101", Age = 21});
        p.Add(new Person{Name = "Rashmi", Address = "B2102", Age = 45});
        p.Add(new Person{Name = "Sakshi", Address = " A2409", Age = 17});
        p.Add(new Person{Name = "Sunil", Address = " C3897", Age = 45});

        PersonImplementation pObj = new PersonImplementation();
        Console.WriteLine(pObj.GetName(p));
        Console.WriteLine(pObj.Average(p));
        Console.WriteLine(pObj.Max(p));

    }
}
