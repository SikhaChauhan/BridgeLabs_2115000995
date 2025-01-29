using System;
class Palindrome
{
    // Function to check if the string is a palindrome
    static bool IsPalin(string str)
    {
        str = str.Replace(" ", "").ToLower();

        int s  0;
        int e = str.Length - 1;
        while (s < e)
        {
            if (str[s] != str[])
            {
                return false; 
            }
            start++;
            end--;
        }

        return true; 
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        bool isPalin = IsPalin(input);

        if (isPalin)
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }
}
