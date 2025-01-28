using System;
class SandL
{
    // Method to find the smallest and largest of three numbers
    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        int small_est = Math.Min(number1, Math.Min(number2, number3));
        int larg_est = Math.Max(number1, Math.Max(number2, number3));
        return new int[] { small_est, larg_est };
    }
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        int[] res = FindSmallestAndLargest(number1, number2, number3);

        Console.WriteLine($"The smallest number is: {res[0]}");
        Console.WriteLine($"The largest number is: {res[1]}");
    }
}
