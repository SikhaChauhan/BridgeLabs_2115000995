using System;
using System.Text;
using System.Collections.Generic;

class StringBuilder2
{
    public static string RemoveDuplicates(string str)
    {
        HashSet<char> seen = new HashSet<char>();
        StringBuilder sb = new StringBuilder();

        foreach (char c in str)
        {
            if (!seen.Contains(c))
            {
                seen.Add(c);
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}
class Program{
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("String after removing duplicates: " + StringBuilder2.RemoveDuplicates(input));
    }
}

