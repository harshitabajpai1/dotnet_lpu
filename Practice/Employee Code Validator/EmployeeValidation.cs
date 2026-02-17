using System.Text.RegularExpressions;
class EmployeeValidator
{
    public List<int> EmployeeCodeValidation(List<string> employeeCode)
    {
        List<int> result = new List<int>();

        Regex regex =new Regex(@"^[A-Z]{2}[0-9]{3}[a-z]{1}$");
        foreach(var code in employeeCode)
        {
            if (!string.IsNullOrEmpty(code) && regex.IsMatch(code) )
            {
                result.Add(1);
            }
            else{ result.Add(0);}
        }

        return  result;
    } 
}