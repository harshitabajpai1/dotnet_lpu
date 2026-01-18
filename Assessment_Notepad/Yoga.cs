//yogaMembership
using System;
using System.Collections;

class MeditationCenter
{
    public int MemberId { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }
    public string Goal { get; set; }
    public double BMI { get; set; }
}

class Program
{
    public static ArrayList memberList = new ArrayList();

    //Add Yoga Member
    public static void AddYogaMember(int memberId, int age, double weight, double height, string goal)
    {
        MeditationCenter member = new MeditationCenter();
		
        member.MemberId = memberId;
        member.Age = age;
        member.Weight = weight;
        member.Height = height;
        member.Goal = goal;

        memberList.Add(member);
    }

    // BMI calculation
    public static double CalculateBMI(int memberId)
    {
        foreach (MeditationCenter member in memberList)
        {
            if (member.MemberId == memberId)
            {
				//bmi = weight/(height^2);
                double bmi = member.Weight / (member.Height * member.Height);
                bmi = Math.Floor(bmi * 100) / 100;
                member.BMI = bmi;
                return bmi;
            }
        }
        return 0;
    }

    // Calculate Yoga Fee
    public static int CalculateYogaFee(int memberId)
    {
        foreach (MeditationCenter member in memberList)
        {
            if (member.MemberId == memberId)
            {
                if (member.Goal == "Weight Loss")
                {
                    if (member.BMI >= 25 && member.BMI < 30)
                        return 2000;
                    else if (member.BMI >= 30 && member.BMI < 35)
                        return 2500;
                    else if (member.BMI >= 35)
                        return 3000;
                }
                else if (member.Goal == "Weight Gain")
                {
                    return 2500;
                }
            }
        }
        return 0;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter MemberId:");
        int id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Age:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Weight:");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Height:");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Goal:  (Weight Gain or Weight Loss");
        string goal = Console.ReadLine();

        AddYogaMember(id, age, weight, height, goal);

        double bmi = CalculateBMI(id);
        if (bmi == 0)
        {
            Console.WriteLine("MemberId not present");
            return;
        }

        Console.WriteLine("BMI: " + bmi);

        int fee = CalculateYogaFee(id);
        Console.WriteLine("Membership Fee: " + fee);
    }
}
