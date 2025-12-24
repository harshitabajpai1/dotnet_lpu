// See https://aka.ms/new-console-template for more information
using HasinaCabs;
Console.WriteLine("Hasina Cabs");
CabDetails cabObj =new CabDetails();
Console.Write("Enter the booking id: ");
cabObj.BookingID = Console.ReadLine();

Console.Write("Enter the cab type: ");
cabObj.CabType = Console.ReadLine();

Console.Write("enter the distance in km: ");
cabObj.DistanceInKm = Double.Parse(Console.ReadLine());

Console.Write("enter the waiting time in minutes: ");
cabObj.WaitingTimeInMinutes = Int32.Parse(Console.ReadLine());

Console.WriteLine("The fare amount is :"+cabObj.CalculateFareAmount());
