// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


class program
{
    public static void Main(string[] args)
    {
        EmployeeValidator employeeObj = new EmployeeValidator();
        Console.Write("Enter the length of the employee code list: ");
        int length = Int32.Parse(Console.ReadLine());
        List<string> employeeCode = new List<string>();
        for(int i =0; i < length; i++)
        {
            employeeCode.Add(Console.ReadLine());
        }
        var result = employeeObj.EmployeeCodeValidation(employeeCode);
        foreach(var item in result)
        {
            Console.WriteLine(item);
        }
    }
}