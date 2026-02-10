using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Take input from user
        Console.Write("word1: ");
        string word1 = Console.ReadLine();

        Console.Write("word2: ");
        string word2 = Console.ReadLine();

    
        HashSet<char> common = new HashSet<char>();
        foreach (char ch in word1)
        {
            if (word2.Contains(ch))
            {
                common.Add(ch);
            }
        }

        int deletions = 0;
        foreach (char ch in word1)
        {
            if (!common.Contains(ch))
            {
                deletions++;
            }
        }

        Console.WriteLine( deletions+"removals");
    }
}
