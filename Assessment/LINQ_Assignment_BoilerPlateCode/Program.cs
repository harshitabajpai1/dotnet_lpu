
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ_Assignment_BoilerPlateCode.Repos;
using LINQ_Assignment_BoilerPlateCode.DTOs;
using LINQ_Assignment_BoilerPlateCode.Models;

namespace LINQ_Assignment_BoilerPlateCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // =======================
            // SAMPLE DATA
            // =======================
            var employees = EmployeeRepo.SeedEmployees();
            var projects = ProjectRepo. SeedProjects();

            Console.WriteLine("LINQ Scenario Boilerplate Loaded");
        }

        // =====================================================
        // 🟢 SECTION 1 – HR ANALYTICS
        // =====================================================

        // TODO 1.1: Get employees earning more than 60,000
        //static List<Employee> GetHighEarningEmployees(List<Employee> employees)
        //{
        //    // TODO: Write LINQ query here
        //    var HighEarningEmployee = employees.Where( e => e.Salary> 60000).ToList();
        //    throw new NotImplementedException();
        //    return HighEarningEmployee;
        //}

        //// TODO 1.2: Get list of employee names only
        //static List<string> GetEmployeeNames(List<Employee> employees)
        //{
        //    // TODO: Write LINQ query here
        //    var EmployeeName = employees.Select(n => n.Name).ToList();
            
        //    //throw new NotImplementedException();
        //    return EmployeeName;
        //}

        //// TODO 1.3: Check if any employee belongs to HR department
        //static bool HasHREmployees(List<Employee> employees)
        //{

        //    // TODO: Write LINQ query here
        //    //as employee have only one dept so >0 means their dept is HR only
        //    bool HasDeptHR = employees.Count(e => e.Department == "HR") >0; // it should return bool
            
        //    //throw new NotImplementedException();
        //    return HasDeptHR;
        //}

        //// =====================================================
        //// 🟡 SECTION 2 – MANAGEMENT INSIGHTS
        //// =====================================================

        //// TODO 2.1: Get department-wise employee count
        //static List<DepartmentCount> GetDepartmentWiseCount(List<Employee> employees)
        //{
        //    // TODO: Write LINQ query here
        //    var DepartmentWiseCount = employees.GroupBy(e => e.Department).Select(n=> new DepartmentCount
        //                                                        {
        //                                                            Department = n.Key,
        //                                                            Count = n.Count()
        //                                                        }).ToList();
        
        //    // throw new NotImplementedException();

        //    return DepartmentWiseCount;
        //}

        //// TODO 2.2: Find the highest paid employee
        //static Employee GetHighestPaidEmployee(List<Employee> employees)
        //{

        //    // TODO: Write LINQ query here
        //    //it will order the salary in desc and then get the first one
        //    var HighestPaidEmployee = employees.OrderByDescending(e => e.Salary).First();
            
        //    // throw new NotImplementedException();
        //    return HighestPaidEmployee;
        //}

        //// TODO 2.3: Sort employees by Salary (DESC), then Name (ASC)
        //static List<Employee> SortEmployeesBySalaryAndName(List<Employee> employees)
        //{
        //    // TODO: Write LINQ query here
        //    var EmployeeSorting = employees.OrderByDescending( e=> e.Salary).ThenBy(e => e.Name).ToList();
            
        //    //throw new NotImplementedException(); 
        //    return EmployeeSorting;
        //}

        //// =====================================================
        //// 🔵 SECTION 3 – PROJECT & SKILL INTELLIGENCE
        //// =====================================================

        //// TODO 3.1: Join employees with projects
        //static List<EmployeeProject> GetEmployeeProjectMappings(
        //    List<Employee> employees,
        //    List<Project> projects)
        //{
        //    // TODO: Write LINQ query here
        //    throw new NotImplementedException();
        //}

        //// TODO 3.2: Find employees who are NOT assigned to any project
        //static List<Employee> GetUnassignedEmployees(
        //    List<Employee> employees,
        //    List<Project> projects)
        //{
        //    // TODO: Write LINQ query here

            
        //    throw new NotImplementedException();
        //}

        //// TODO 3.3: Get all unique skills across the organization
        //static List<string> GetAllUniqueSkills(List<Employee> employees)
        //{

        //    // TODO: Write LINQ query here
        //    var Employee = employees.Select(e => e.Skills).Distinct().ToList();
        //    //throw new NotImplementedException();
        //    return Employee;

        //}

        //// =====================================================
        //// 🔴 SECTION 4 – ADVANCED WORKFORCE ANALYTICS
        //// =====================================================

        //// TODO 4.1: Get top 3 highest-paid employees per department
        //static List<DepartmentTopEmployees> GetTopEarnersByDepartment(
        //    List<Employee> employees)
        //{
        //    // TODO: Write LINQ query here
        //    var TopEarnersByDept=employees.GroupBy(e => e.Department).Select(n => new DepartmentTopEmployees
        //                            {
        //                                Department = n.Key,
        //                                TopEmployees = n.OrderByDescending(e => e.Salary).Take(3).ToList()
        //                            }).ToList();
                
        
        //    // throw new NotImplementedException();
        //    return TopEarnerByDept;
        //}

        //// TODO 4.2: Remove duplicate employees based on Id
        //static List<Employee> RemoveDuplicateEmployees(List<Employee> employees)
        //{
        //    // TODO: Write LINQ query here
        //    var RemoveDuplicate = employees.GroupBy(e => e.Id).Select(n =>n.First()).ToList();
        
        //    // throw new NotImplementedException();
        //    return RemoveDuplicate;
        //}

        //// TODO 4.3: Implement pagination
        //static List<Employee> GetEmployeesByPage(
        //    List<Employee> employees,
        //    int pageNumber,
        //    int pageSize = 5)
        //{
        //    // TODO: Write LINQ query here
        //    throw new NotImplementedException();
        //}


    }
}
