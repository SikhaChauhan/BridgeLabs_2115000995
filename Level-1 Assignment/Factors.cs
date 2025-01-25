using System;
class Factors
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Solve(num);
    }
    // This function finds all the factors of a number
    static void Solve(int num)
    {
        int[] arr = new int[num];
        int idx = 0;

        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
            {
                arr[idx++] = i;
            }
        }
        Array.Resize(ref arr, idx);
        PrintArray(arr);
    }
    // This function prints the contents of the array
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
