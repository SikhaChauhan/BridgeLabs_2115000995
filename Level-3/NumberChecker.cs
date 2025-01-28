/* using System;
class NumberChecker
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

    // This function checks if a number is a duck number
    public static bool Duck_Num(int num)
    {
        string numStr = num.ToString();
        return numStr.Contains("0") && numStr[0] != '0'; 
    }

    // This function checks if the number is an Armstrong number
    public static bool Armstrong_Num(int num)
    {
        int[] digits = Digits_Arr(num);
        int numDigits = digits.Length;
        int sum = 0;

        foreach (int digit in digits)
        {
            sum += (int)Math.Pow(digit, numDigits);
        }
        return sum == num;
    }

    // This function finds the largest and second largest elements in the digits array
    public static (int larg_est, int sec_Largest) Largest_SecondLargest(int[] digits)
    {
        int larg_est = int.MinValue, second_Largest = int.MinValue;
        foreach (int digit in digits)
        {
            if (digit > larg_est)
            {
                second_Largest = larg_est;
                larg_est = digit;
            }
            else if (digit > second_Largest && digit != larg_est)
            {
                second_Largest = digit;
            }
        }
        return (larg_est, second_Largest);
    }

    // This function finds the smallest and second smallest elements in the digits array
    public static (int small_est, int second_Smallest) Smallest_SecondSmallest(int[] digits)
    {
        int small_est = int.MaxValue, second_Smallest = int.MaxValue;
        foreach (int digit in digits)
        {
            if (digit < small_est)
            {
                second_Smallest = small_est;
                small_est = digit;
            }
            else if (digit < second_Smallest && digit != small_est)
            {
                second_Smallest = digit;
            }
        }
        return (small_est, second_Smallest);
    }

    public static void Main(string[] args)
    {
		Console.WriteLine($"Enter Number:");
        int num = Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine($"Number: {num}");
        Console.WriteLine($"Count of digits: {Cnt_Digits(num)}");

        int[] digits = Digits_Arr(num);
        Console.WriteLine($"Digits: {string.Join(", ", digits)}");

        Console.WriteLine($"Is Duck Number: {Duck_Num(num)}");
        Console.WriteLine($"Is Armstrong Number: {Armstrong_Num(num)}");

        var (larg_est, second_Largest) = Largest_SecondLargest(digits);
        Console.WriteLine($"Largest digit: {larg_est}, Second largest digit: {second_Largest}");

        var (small_est, second_Smallest) = Smallest_SecondSmallest(digits);
        Console.WriteLine($"Smallest digit: {small_est}, Second smallest digit: {second_Smallest}");
    }
}
 */