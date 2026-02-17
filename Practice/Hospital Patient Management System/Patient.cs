public class Patient
{
    public int Id{get; set;}
    public string Name{get; set;}
    public int Age{get; set;}
    public string Condition{get; set;}

    // Dictionary<int,Patient> PatientDetails =null;
    // Queue<Patient> AppointmentList = null;
    // List<string> PatientHistory = null;

    public Patient(int id, string name, int age, string condition)
    {
        Id = id;
        Name = name;
        Age =age;
        Condition = condition;

    }
}