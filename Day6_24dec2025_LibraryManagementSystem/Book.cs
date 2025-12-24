using System;
namespace LibraryManagementSystem
{
    public class Book
    {
        string title;
        string author;
        int numPages;
        DateTime returnedDate;
        DateTime dueDate;

//Default constructor;
        public Book()
        {
            
        }

        //parameterize constructor
        public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate)
        {
            this.title = title;
            this.author = author;
            this.numPages = numPages;
            this.dueDate = dueDate;
            this.returnedDate = returnedDate;
        }

        public double AveragePagesReadPerDay(int daysToRead)
        {
            return (double)numPages/ daysToRead;
        }

        public double CalculateLateFee(double dailyLateFeeRate)
        {
            int lateDays = (returnedDate -  dueDate).Days;
            if(lateDays > 0)
            {
                return lateDays * dailyLateFeeRate;
            }
            else
            {
                return 0;
            }
        }
    }
}