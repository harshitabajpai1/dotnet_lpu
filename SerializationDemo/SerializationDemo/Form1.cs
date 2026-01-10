using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// for binary serialization
using System.Runtime.Serialization.Formatters.Binary;

//for xml serialization 
using System.Xml.Serialization;
//for soap serialization
using System.Runtime.Serialization.Formatters.Soap;

namespace SerializationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void btnBinSerialize_Click(object sender, EventArgs e)
        {
            

        }

        //to deserialize the object and show the data in GUI form

        private void btnBinDeSerialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\dotnet\SerializationDemo\data.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();

            Employee emp1 = (Employee)bf.Deserialize(fs);
            //Employee emp1 = new Employee();
            txtEmployeeID.Text = emp1.Id.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();
            fs.Close();

        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }
        //to assign the data to object and serialize from the GUI form

        private void btnBinSerialize_Click_1(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.Id = Convert.ToInt32(txtEmployeeID.Text);
            emp1.Name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            //binary serialization process
            FileStream fs = new FileStream(@"C:\dotnet\SerializationDemo\data.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, emp1);




            foreach (var item in this.Controls)  //item is in controls collection  ..
                                                 //. controls collection contains all the controls present in the form UI elements
            {
                if (item.GetType() == typeof(TextBox))   //item is still control just checking its type
                {
                    TextBox txtBox = (TextBox)item;   // we are casting item to textbox type
                    txtBox.Clear();

                }
            }
            fs.Close();
            MessageBox.Show("Record added  ...");

        }

        private void btnXmlSerialize_Click(object sender, EventArgs e)
        {

        }

        private void btnXmlDeSerialize_Click(object sender, EventArgs e)
        {

        }

        private void btnSoapSerialize_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee();
            emp1.Id = Convert.ToInt32(txtEmployeeID.Text);
            emp1.Name = txtName.Text;
            emp1.Salary = Convert.ToInt32(txtSalary.Text);

            //binary serialization process
            FileStream fs = new FileStream(@"C:\dotnet\SerializationDemo\SoapSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter bf = new SoapFormatter();
            bf.Serialize(fs, emp1);




            foreach (var item in this.Controls)  //item is in controls collection  ..
                                                 //. controls collection contains all the controls present in the form UI elements
            {
                if (item.GetType() == typeof(TextBox))   //item is still control just checking its type
                {
                    TextBox txtBox = (TextBox)item;   // we are casting item to textbox type
                    txtBox.Clear();

                }
            }
            fs.Close();
            MessageBox.Show("Record added  ...");

        }

        private void btnSoapDeSerialize_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\dotnet\SerializationDemo\SoapSerialize.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter bf = new SoapFormatter();

            Employee emp1 = (Employee)bf.Deserialize(fs);
            //Employee emp1 = new Employee();
            txtEmployeeID.Text = emp1.Id.ToString();
            txtName.Text = emp1.Name;
            txtSalary.Text = emp1.Salary.ToString();
            fs.Close();

        }
    }
}
