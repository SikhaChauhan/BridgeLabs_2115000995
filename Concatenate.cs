using System;
using System.Text;

class Concatenate {
    public static string ConcatenateStrings(string[] words)
    {
        StringBuilder sb = new StringBuilder();
        foreach (string word in words)
        {
            sb.Append(word);
        }
        return sb.ToString();
    }
}

class Program
{
    public static void Main()
    {
        Console.Write("Enter the number of strings: ");
        int n = int.Parse(Console.ReadLine());

        string[] words = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter string {i + 1}: ");
            words[i] = Console.ReadLine();
        }

        Console.WriteLine("Concatenated String: " + Concatenate.ConcatenateStrings(words));
    }
}