using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    [Serializable]  //Attribute to indicate that this class can be serialized
    public  class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }


        //Attribute to indicate that this field should not be serialized] 
        //non serialized fields must be private
        //it cant be public property
        //public int Salary { get; set; }

        [NonSerialized]

        int sal;
        public int Salary
        {
            get { return sal; }
            set { sal = value; }
        }
    }
}
