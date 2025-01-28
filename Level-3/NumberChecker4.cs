/* using System;
class NumberChecker4
{
    // This function checks if a number is a prime number
    public static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    // This function checks if a number is a neon number
    public static bool IsNeon(int num)
    {
        int sq = num * num;
        int sum_Digits = 0;

        while (sq > 0)
        {
            sum_Digits += sq % 10;
            sq /= 10;
        }

        return sum_Digits == num;
    }

    // This function checks if a number is a spy number
    public static bool IsSpy(int num)
    {
        int sum_Digits = 0, prod_Digits = 1;

        while (num > 0)
        {
            int digit = num % 10;
            sum_Digits += digit;
            prod_Digits *= digit;
            num /= 10;
        }

        return sum_Digits == prod_Digits;
    }

    // This function checks if a number is an automorphic number
    public static bool IsAutomorphic(int num)
    {
        int sq = num * num;
        string numStr = num.ToString();
        string sqStr = sq.ToString();

        return sqStr.EndsWith(numStr);
    }

    // This function checks if a number is a buzz number
    public static bool IsBuzz(int num)
    {
        return num % 7 == 0 || num % 10 == 7;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine($"Enter Test Number:");
        int test_Num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Number: {test_Num}");
        Console.WriteLine($"Is Prime: {IsPrime(test_Num)}");
        Console.WriteLine($"Is Neon: {IsNeon(test_Num)}");
        Console.WriteLine($"Is Spy: {IsSpy(test_Num)}");
        Console.WriteLine($"Is Automorphic: {IsAutomorphic(test_Num)}");
        Console.WriteLine($"Is Buzz: {IsBuzz(test_Num)}");
    }
}
 */