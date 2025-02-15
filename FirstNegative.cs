using System;
class FirstNegative
{
    public static int FindFirstNegative(int[] arr)
    {
        foreach (int num in arr)
        {
            if (num < 0)
                return num;
        }
        return int.MaxValue;
    }
}

class Program
{
    public static void Main()
    {
        Console.Write("Enter array elements separated by space: ");
        string input = Console.ReadLine();

        try
        {
            int[] numbers = Array.ConvertAll(
                input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries),
                s => int.Parse(s.Trim())
            );

            int firstNegative = FirstNegative.FindFirstNegative(numbers);

            if (firstNegative == int.MaxValue)
                Console.WriteLine("No negative number found in the array.");
            else
                Console.WriteLine($"First negative number: {firstNegative}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter only integers separated by spaces.");
        }
    }
}
