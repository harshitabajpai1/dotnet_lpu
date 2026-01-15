using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinReflectionDemo_Jan15_2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();


        }

        private void btnLoadAssembly_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.ShowDialog();
            string FileName  = openFileDialog1.FileName;    
            Assembly assemblyObj = Assembly.LoadFrom(FileName);  //Reflection 

            Type[] myType = assemblyObj.GetTypes();
            //Form1.ReflectAll(myType[0]);  --- static method call
            //this.ReflectAll(myType[0]);   //instance method call
            this.ReflectAll(myType[1]);

        }
        public void ReflectAll(Type typeObj)
        {
            //Get all the methods of the type
            MethodInfo[] methodList = typeObj.GetMethods();

            //get all properties of the type
            PropertyInfo[] propertyList = typeObj.GetProperties();

            //similary we have events, fields, constructors etc 
            //eg: FieldInfo[] fieldList = typeObj.GetFields();
            //eg: ConstructorInfo[] constructorList = typeObj.GetConstructors();
            //eg: EventInfo[] eventList = typeObj.GetEvents();


            //Load All properties in listBox1
            foreach(var item in propertyList)
            {
                listBox1.Items.Add(item);    //we cant call instance member in static method

            }

            //load all methods in listBox2
            foreach(var item in methodList)
            {
                listBox2.Items.Add(item);
            }
        }
    }
}
