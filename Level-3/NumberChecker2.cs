/* using System;
class NumberChecker2
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

    // This function finds the sum of the digits of a number
    public static int Sum_Digits(int[] digits)
    {
        int sum = 0;
        foreach (int digit in digits)
        {
            sum += digit;
        }
        return sum;
    }

    // This function finds the sum of the squares of the digits of a number
    public static int Sum_Sq_Digits(int[] digits)
    {
        int sum_Sq = 0;
        foreach (int digit in digits)
        {
            sum_Sq += (int)Math.Pow(digit, 2);
        }
        return sum_Sq;
    }

    // This function checks if a number is a Harshad number
    public static bool Harshad_Num(int num, int[] digits)
    {
        int sum_Digits = Sum_Digits(digits);
        return num % sum_Digits == 0;
    }

    // This function finds the frequency of each digit in the number
    public static int[,] Digit_Freq(int[] digits)
    {
        int[,] freq = new int[10, 2];

        for (int i = 0; i < 10; i++)
        {
            freq[i, 0] = i; 
            freq[i, 1] = 0; 
        }

        foreach (int digit in digits)
        {
            freq[digit, 1]++;
        }

        return freq;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine($"Enter Number:");
        int num = Convert.ToInt32(Console.ReadLine());  

        Console.WriteLine($"Number: {num}");
        Console.WriteLine($"Count of digits: {Cnt_Digits(num)}");

        int[] digits = Digits_Arr(num);
        Console.WriteLine($"Digits: {string.Join(", ", digits)}");

        Console.WriteLine($"Sum of digits: {Sum_Digits(digits)}");
        Console.WriteLine($"Sum of squares of digits: {Sum_Sq_Digits(digits)}");

        Console.WriteLine($"Is Harshad Number: {Harshad_Num(num, digits)}");

        int[,] freq = Digit_Freq(digits);
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (freq[i, 1] > 0)
            {
                Console.WriteLine($"Digit: {freq[i, 0]}, Frequency: {freq[i, 1]}");
            }
        }
    }
}
 */