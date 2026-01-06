// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Collections.Generic;
namespace CustomPropertyDemo
{
    struct Customer1    //value type in c sharp   --->memory automaticaly reclaimed as the memory goes to stack memory
    {
        int id;
        string name;
        // public int ID{get; set;} = 0;
        // public string Name{get;set;}



        //Constructor is just to initialize the data to private memners of the struct as 
        // hte struct is value type so no need of memory allocation ... 
        // and we dont have default constructor but paramererise constructor
        //Deconstuctoer is not there as there is no need for memory deallocztion

        //struct is light weight
            
        public Customer1(int id1, string name1)
        {
            id = id1;
            name = name1;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Init Customer Object

            Customer  custObj = new Customer();
            custObj.CustID =  101;
            custObj.Name = "Harshita Bajpai";

            //initalizing the shipping address
            custObj.ShippingAddr = new Address();
            custObj.ShippingAddr.FlatNo = 1803;
            custObj.ShippingAddr.BuildingName = "Sky Tower";
            custObj.ShippingAddr.Street="Lane 2";
            custObj.ShippingAddr.Locality = "kailash nagar";
            custObj.ShippingAddr.City = "Kanpur";




            //1 Customer - Have - Many -Orders

            //if setter block is protected you cant initialize via object
            //now we need data member to initialize (Encapsulate the protected set block)
            custObj.MyOrders = new List<Orders>()
            {
                new Orders{OrderID = 1124, OrderDate=new DateTime(2001,12,22),Amount = 14000}, //yyyy - mm - dd
                new Orders{OrderID = 1125, OrderDate=new DateTime(2001,12,23),Amount = 19000},
                new Orders{OrderID = 1128, OrderDate=new DateTime(2001,12,24),Amount = 18700},
                new Orders{OrderID = 1123, OrderDate=new DateTime(2001,12,21),Amount = 17000},
                new Orders{OrderID = 1129, OrderDate=new DateTime(2001,12,24),Amount = 16000},
                new Orders{OrderID = 1130, OrderDate=new DateTime(2001,12,25),Amount = 13000},
            };
        }
    }
}
