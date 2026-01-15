namespace PersonDetails
{
    class PersonImplementation
    {
        public string GetName(IList<Person> person)
        {
            string NameDetails = "";
            foreach(Person p in person)
            {
                string details = p.Name +" "+p.Address+" ";
                NameDetails += details ;
            }
            return NameDetails;
        }

        public double Average(IList<Person> person)
        {
            
            var average = person.Average(e => e.Age);
            return average;
        }

        public int Max(IList<Person> person)
        {
            var max = person.Max(e => e.Age);
            return max;
        }
    }
}