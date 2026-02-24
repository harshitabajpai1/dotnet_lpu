// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Collections.Generic;
class MemberStats
{
    public string Name{get;set;}
    public List<int> WeeklyStepCount{get;set;}
}
class Program
{
    static List<MemberStats> LeaderBoard = new List<MemberStats>();
    public static void AddMember(MemberStats member)
    {
        LeaderBoard.Add(member);
    }

    public static Dictionary<string,int> MoreThanThreshold(int StepThreshold)
    {
        Dictionary<string,int> result = new Dictionary<string,int>();

        return result;
    }
}