using System;
namespace CustomPropertyDemo
{
    public class Customer
    {
        //Auto Implicit Properties

        public int CustID {get; set;}
        public string Name{get; set;}
        public Address BillingAddr{get;set;}

        public Address  ShippingAddr{get;set;}


        public List<Orders> orderList;


        // Orders[] myOrders = null;
        //constructor
        public Customer()
        {
            orderList = new List<Orders>();
        }

        public List<Orders> MyOrders
        {
            get
            {
                return orderList;
            }
            protected set
            {
                orderList = value;
            }
        }
    }
}