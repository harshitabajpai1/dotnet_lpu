namespace CustomPropertyDemo
{
    class PrimeCustomer : Customer
    {
        //Encapsulating the myOrders
        public List<Orders> MyPrimeOrders   //Write Only Property
        {
            set
            {
                MyOrders = value;
            }
        }
    }
}