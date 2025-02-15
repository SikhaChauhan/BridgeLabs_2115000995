using System;
using System.Text;

class String_Builder
{
    public static string ReverseString(string str)
    {
        StringBuilder sb = new StringBuilder(str);
        int left = 0, right = sb.Length - 1;
        
        while (left < right)
        {
            char temp = sb[left];
            sb[left] = sb[right];
            sb[right] = temp;

            left++;
            right--;
        }
        return sb.ToString();
    }
}

class Program
{
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("Reversed String: " + String_Builder.ReverseString(input));
    }
}