//User Verification
using System;

class User{
	public string Name{get; set;}
	public string PhoneNumber {get; set;}
	
	
}
class InvalidPhoneNumberException :Exception{
	public  InvalidPhoneNumberException(string message) :base(message){
		
	}
}

//Program Class
class Program{
	public static User ValidatePhoneNumber(string name, string phoneNumber){
		
		if(phoneNumber.Length == 10){
			User userObj = new User();
			userObj.Name = name;
			userObj.PhoneNumber = phoneNumber;	
			return userObj;
		}
		else{
			throw new InvalidPhoneNumberException("Invalid phone number");
		}
	}
	
	public static void Main(string[] args){
		try{
			Console.Write("Enter the name: ");
			string name = Console.ReadLine();
			
			Console.Write("Enter the number: ");
			string phoneNumber = Console.ReadLine();
			
			User result = ValidatePhoneNumber(name, phoneNumber);
			
			Console.WriteLine("Nmae: "+result.Name);
			Console.WriteLine("Phone Number: "+result.PhoneNumber);
			
		}
		catch(InvalidPhoneNumberException e){
			Console.WriteLine(e.Message);
		}
	}
}