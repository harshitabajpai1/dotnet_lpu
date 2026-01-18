//User Authentication

using System;

// User class
class User
{
    public string Name { get; set; }
    public string Password { get; set; }
    public string ConfirmationPassword { get; set; }
}

// Custom  Exception
class PasswordMismatchException : Exception
{
    public PasswordMismatchException(string message) : base(message)   //constructor chaining
    {
    }
}

class Program
{
    // ValidatePassword method
    public static User ValidatePassword(string name, string password, string confirmationPassword)
    {
        if (!password.Equals(confirmationPassword))
        {
            throw new PasswordMismatchException("Password entered does not match");
        }

        User user = new User();
        user.Name = name;
        user.Password = password;
        user.ConfirmationPassword = confirmationPassword;

        return user;
    }

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();

            Console.WriteLine("Enter Confirm Password:");
            string confirmPassword = Console.ReadLine();

            User user = ValidatePassword(name, password, confirmPassword);

            if (user != null)
            {
                Console.WriteLine("Registered Successfully");
            }
        }
        catch (PasswordMismatchException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
