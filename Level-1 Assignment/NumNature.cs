using System;
class NumNature
{
	static void Main(string[] args)
    {
        int[] arr = new int[5];
        Console.WriteLine("Enter the numbers: ");

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        nature(arr);
    }
    // This function is used to find out whether a number is +ve,
    // -ve, or zero by iterating through an array
	static void nature(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                Console.WriteLine($"{arr[i]} -> Positive");
            }
            else if (arr[i] < 0)
            {
                Console.WriteLine($"{arr[i]} -> Negative");
            }
            else
            {
                Console.WriteLine($"{arr[i]} -> Zero");
            }
        }
    }
}
