// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using PhoneCallSubscription;

public class Program
{
    public static void Main(String[] args)
    {
        PhoneCall callObj = new PhoneCall();   //instance of the phone call class... which we will use to call the other methods and properties of the class

        //Menu for the user input
        Console.WriteLine("Phone call subscription : Choose the option ");
        Console.WriteLine("1. Subscribe to the call");
        Console.WriteLine("2.UnSubscribe to the call ");

        int choice = Int32.Parse(Console.ReadLine());
        bool notify = false;
        switch (choice)
        {
            case 1:
                {
                    notify = true;
                    break;
                }
            case 2:
                {
                    notify = false;
                    break;
                }
            default:{
                    Console.WriteLine("Enter a valid choice (1 or 2)");
                    break;
                }
        }
        callObj.MakeAPhoneCall(notify);
        Console.WriteLine(callObj.Message);
    }
}