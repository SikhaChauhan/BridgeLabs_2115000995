using System;
class Palindrome_Checker
{
    // Function to take input from the user
    static string Enter_Input()
    {
        Console.Write("Enter a string: ");
        return Console.ReadLine();
    }

    // Function to check if a string is a palindrome
    static bool IsPalindrome(string input)
    {
        int s = 0;
        int e = input.Length - 1;

        while (s < e)
        {
            if (!Char.IsLetterOrDigit(input[s]))
            {
                s++;
            }
            else if (!Char.IsLetterOrDigit(input[e]))
            {
                e--;
            }
            else
            {
                if (Char.ToLower(input[s]) != Char.ToLower(input[e]))
                {
                    return false; 
                }
                s++;
                e--;
            }
        }
        return true; 
    }

    // Function to display the result
    static void Display_Res(bool isPalindrome)
    {
        if (isPalindrome)
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }

    static void Main()
    {
        string input = Enter_Input();
        bool res = IsPalindrome(input);
        Display_Res(res);
    }
}
