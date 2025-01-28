/* using System;

class NumberChecker3
{
    // This function finds the count of digits in the number
    public static int Cnt_Digits(int num)
    {
        return num.ToString().Length;
    }

    // This function stores the digits of the number in a digits array
    public static int[] Digits_Arr(int num)
    {
        string numStr = num.ToString();
        int[] digits = new int[numStr.Length];
        for (int i = 0; i < numStr.Length; i++)
        {
            digits[i] = int.Parse(numStr[i].ToString());
        }
        return digits;
    }

    // This function reverses the digits array
    public static int[] Rev_Digits_Arr(int[] digits)
    {
        int[] rev = new int[digits.Length];
        for (int i = 0, j = digits.Length - 1; i < digits.Length; i++, j--)
        {
            rev[i] = digits[j];
        }
        return rev;
    }

    // This function compares two arrays and check if they are equal
    public static bool Array_Equal(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            return false;
        }

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        }

        return true;
    }

    // This function checks if a number is a palindrome using the digits array
    public static bool Palin_drome(int[] digits)
    {
        int[] rev = Rev_Digits_Arr(digits);
        return Array_Equal(digits, rev);
    }

    // This function checks if a number is a duck number
    public static bool Duck_Num(int[] digits)
    {
        for (int i = 1; i < digits.Length; i++) 
        {
            if (digits[i] == 0)
            {
                return true;
            }
        }
        return false;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine($"Enter Number:");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Number: {num}");
        Console.WriteLine($"Count of digits: {Cnt_Digits(num)}");

        int[] digits = Digits_Arr(num);
        Console.WriteLine($"Digits: {string.Join(", ", digits)}");

        int[] rev_Digits = Rev_Digits_Arr(digits);
        Console.WriteLine($"Reversed Digits: {string.Join(", ", rev_Digits)}");

        Console.WriteLine($"Is Palindrome: {Palin_drome(digits)}");
        Console.WriteLine($"Is Duck Number: {Duck_Num(digits)}");
    }
}
 */