using System;
namespace MediSureClinicBilling
{
    class Billing
    {
        static PatientBill LastBill ;
        static bool HasLastBill = false;

        public void CreateBill()
        {
            PatientBill billObj = new PatientBill();
            Console.Write("Enter the Billing Id: ");
            billObj.BillID = Console.ReadLine();

            if(billObj.BillID == null)
            {
                Console.WriteLine("Billing Id cannot be empty");
                return;
            }
            Console.Write("Enter the patient name: ");
            billObj.PatientName = Console.ReadLine();

            Console.Write("The Patient has Insurance or not( enter Y/N):");
            string answer= Console.ReadLine();
            if(answer == "y" | answer == "Y")
            {
                billObj.HasInsurance = true;
            }else if (answer =="n" | answer == "N")
            {
                billObj.HasInsurance = false;
            }
            else
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            Console.Write("Enter the Consultation Fee: ");
            billObj.ConsultationFee = decimal.Parse(Console.ReadLine());
            if (billObj.ConsultationFee <= 0)
            {
                Console.WriteLine("Consultation fees must be greater than 0");
                return;
            }

            Console.Write("Enter the Lab Charges: ");
            billObj.LabCharges = decimal.Parse(Console.ReadLine());
            if (billObj.LabCharges <0)
            {
                Console.WriteLine("Lab Charges must be greater than equal to 0");
                return;
            }

            Console.Write("Enter the Medicine Charges: ");
            billObj.MedicineCharges = decimal.Parse(Console.ReadLine());
            if (billObj.MedicineCharges < 0)
            {
                Console.WriteLine("Medicine Charges must be greater than equal to 0");
                return;
            }

            //Calculating the Amounts for the bill;

            billObj.GrossAmount = billObj.ConsultationFee + billObj.LabCharges + billObj.MedicineCharges;
            if(billObj.HasInsurance == true)
            {
                //on insurance 10% discount on gross amount;
                billObj.DiscountAmount = billObj.GrossAmount * 10 / 100;
            }else if(billObj.HasInsurance == false)
            {
                billObj.DiscountAmount = 0;
            }


            //Final billing amount;
            billObj.FinalPayable = billObj.GrossAmount - billObj.DiscountAmount;

            //Assinging the bill obj  to lastBill;
            LastBill = billObj;
            HasLastBill = true;

            Console.WriteLine("Bill Created Sucessfully");
            Console.WriteLine("Gross Amount: "+billObj.GrossAmount);
            Console.WriteLine("Discount Amount: "+billObj.DiscountAmount);
            Console.WriteLine("Final Payable: "+billObj.FinalPayable);
            

        }
        public void viewBill()
        {
            if (!HasLastBill)
            {
                Console.Write("No bill available. Please create a new bill first.");
            }
            else
            {
                Console.WriteLine("--------------Last Bill----------");
                Console.WriteLine("BillId: "+LastBill.BillID);
                Console.WriteLine("Patient: "+LastBill.PatientName);
                if(LastBill.HasInsurance == true)
                {
                    Console.WriteLine("Insured: Yes");
                }
                else if(LastBill.HasInsurance == false)
                {
                    Console.WriteLine("Insured: No");
                }
                Console.WriteLine("Consultation Fee: "+LastBill.ConsultationFee);
                Console.WriteLine("Lab Charges: "+LastBill.LabCharges);
                Console.WriteLine("Medicine Charge:"+LastBill.MedicineCharges);
                Console.WriteLine("Gross Amount:  "+LastBill.GrossAmount);
                Console.WriteLine("Discount Amount: "+LastBill.DiscountAmount);
                Console.WriteLine("Final Payable: "+LastBill.FinalPayable);
                Console.WriteLine("------------------------------------");
                
            }
        }
        public void ClearLastBill()
        {
            LastBill = null;
            HasLastBill = false;
            Console.WriteLine("Last bill cleared");
        }
    }
}