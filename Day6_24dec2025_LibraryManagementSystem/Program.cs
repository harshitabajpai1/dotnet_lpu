// See https://aka.ms/new-console-template for more information
using LibraryManagementSystem;
Console.WriteLine("Libraray Management System");

Console.ForegroundColor  =ConsoleColor.Magenta;
Console.Write("Enter the title: ");
string title = Console.ReadLine();

Console.Write("Enter Author: ");
string author = Console.ReadLine();

Console.Write("Enter the number of pages: ");
int numPages = Int32.Parse(Console.ReadLine());

Console.Write("enter the due date: ");
DateTime dueDate = DateTime.Parse(Console.ReadLine());

Console.Write("enter the returned date: ");
DateTime returnedDate= DateTime.Parse(Console.ReadLine());

Console.Write("Enter the days to read: ");
int daysToRead = Int32.Parse(Console.ReadLine());

Console.Write("Enter the daily late fee rate: ");
int dailyLateFeeRate = Int32.Parse(Console.ReadLine());


//calling the constructor;
Book book  = new Book(title,author,numPages,dueDate,returnedDate);

//calling methods

double averageRead = book.AveragePagesReadPerDay(daysToRead);
double lateFees = book.CalculateLateFee(dailyLateFeeRate);

Console.WriteLine("the average read per days is: "+averageRead);
Console.WriteLine("the late fees is : "+lateFees);

Console.ForegroundColor = ConsoleColor.White;



