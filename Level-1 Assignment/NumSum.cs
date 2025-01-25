using System;
class NumSum
{
	static void Main(string[] args)
    {
        Console.WriteLine("Enter up to 10 numbers (enter 0 or a -ve number to exit):");
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            arr[i] = num;

            if (num == 0 || num < 0)
                break;
        }
        Sum(arr);
    }
    // This function is used to print all the numbers and their sum
    static void Sum(int[] arr)
    {
        int sum = 0;
        Console.WriteLine("Numbers Entered:");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
                break;

            Console.WriteLine($"{arr[i]}");
            sum += arr[i];
        }
        Console.WriteLine($"Sum of all the numbers is: {sum}");
    }
}
