public class HospitalManager
{
    private Dictionary<int, Patient> _patients = new Dictionary<int, Patient>();
    private Queue<Patient> _appointmentQueue = new Queue<Patient>();
    
    // Add a new patient to the system
    Patient patientObj = null;
    public void RegisterPatient(int id, string name, int age, string condition)
    {
        // TODO: Create patient and add to dictionary
        patientObj = new Patient(id,name,age,condition);
        _patients.Add(id,patientObj);

    }
    
    // Add patient to appointment queue
    public void ScheduleAppointment(int patientId)
    {
        // TODO: Find patient and add to queue
        foreach(int id in _patients.Keys)
        {
            if(id == patientId)
            {
                _appointmentQueue.Enqueue(_patients[patientId]);
            }

        }
    }
    
    // Process next appointment (remove from queue)
    public Patient ProcessNextAppointment()
    {
        // TODO: Return and remove next patient from queue
        if(_appointmentQueue == null)
        {
            throw new ArgumentException("the Appointment queue is null");
        }
        return _appointmentQueue.Dequeue();
    }
    
    // Find patients with specific condition using LINQ
    public List<Patient> FindPatientsByCondition(string condition)
    {
        // TODO: Use LINQ to filter patients
        var PatientByCondition = _patients.Where(p=>p.Value.Condition == condition).Select(p=>p.Value).ToList();
        return PatientByCondition;
        
    }
}
