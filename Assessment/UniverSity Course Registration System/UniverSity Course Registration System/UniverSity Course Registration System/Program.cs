using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
     // =========================
    // Program (Menu-Driven)
    // =========================
    class Program
    {
        static void Main()
        {
            UniversitySystem system = new UniversitySystem();
            bool exit = false;

            Console.WriteLine("Welcome to University Course Registration System");

            while (!exit)
            {
                Console.WriteLine("\n1. Add Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Register Student for Course");
                Console.WriteLine("4. Drop Student from Course");
                Console.WriteLine("5. Display All Courses");
                Console.WriteLine("6. Display Student Schedule");
                Console.WriteLine("7. Display System Summary");
                Console.WriteLine("8. Exit");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();
                try
                {
                    switch (choice)
                    {
                        case "1": // Add Course
                            Console.Write("Course Code: ");
                            string cCode = Console.ReadLine();

                            Console.Write("Course Name: ");
                            string cName = Console.ReadLine();

                            Console.Write("Credits: ");
                            int credits = int.Parse(Console.ReadLine());

                            system.AddCourse(cCode, cName, credits);
                            Console.WriteLine("Course Added.");
                            break;

                        case "2": // Add Student
                            Console.Write("Student ID: ");
                            string sId = Console.ReadLine();

                            Console.Write("Student Name: ");
                            string sName = Console.ReadLine();

                            Console.Write("Major: ");
                            string major = Console.ReadLine();

                            system.AddStudent(sId, sName, major);
                            Console.WriteLine("Student Added.");
                            break;

                        case "3": // Register
                            Console.Write("Student ID: ");
                            string rsId = Console.ReadLine();

                            Console.Write("Course Code: ");
                            string rsCourse = Console.ReadLine();

                            system.RegisterStudentForCourse(rsId, rsCourse);
                            break;

                        case "4": // Drop
                            Console.Write("Student ID: ");
                            string dsId = Console.ReadLine();

                            Console.Write("Course Code: ");
                            string dsCourse = Console.ReadLine();

                            system.DropStudentFromCourse(dsId, dsCourse);
                            break;

                        case "5": // Display Courses
                            system.DisplayAllCourses();
                            break;

                        case "6": // Student Schedule
                            Console.Write("Student ID: ");
                            string schId = Console.ReadLine();

                            system.DisplayStudentSchedule(schId);
                            break;

                        case "7": // Summary
                            system.DisplaySystemSummary();
                            break;

                        case "8": // Exit
                            exit = true;
                            Console.WriteLine("Goodbye!");
                            break;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

