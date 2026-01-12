using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_ConsoleApp
{
    public class StudentRepo
    {
        static List<Student> StudentList = null;

        public StudentRepo()
        {
            if(StudentList == null)
            {
                //collection initializer
                StudentList = new List<Student>() {
                    new Student(){RollNo = 1,Name = "Alok", Gender = "Male",Marks = 80,Fees = 2400},
                    new Student(){RollNo = 2,Name = "janvi", Gender = "Female",Marks = 60,Fees = 1800},
                    new Student(){RollNo = 3,Name = "Khushi", Gender = "Female",Marks = 56,Fees = 1800},
                    new Student(){RollNo = 4,Name = "Anshu", Gender = "Female",Marks = 87,Fees = 1200},
                    new Student(){RollNo = 5,Name = "Shaheer", Gender = "Male",Marks = 90,Fees = 2400},
                    new Student(){RollNo = 6,Name = "Abhishek", Gender = "Male",Marks = 75, Fees = 2400},
                    new Student(){RollNo = 7,Name = "Salman", Gender = "Male",Marks = 50, Fees = 2400},


                };

                
            }
        }
        public List<Student> GetAllStudents()
        {
            return StudentList;

        }
    }
}
