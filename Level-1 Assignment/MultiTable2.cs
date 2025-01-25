using System;
class MultiTable2
{
	static void Main(string[] args)
    {
        Console.WriteLine("Enter a number (6 - 9): ");
        int num = Convert.ToInt32(Console.ReadLine());
        Sum(num);
    }
    // This function is used to print the multiplication table of the number
    // by storing the multiples in an array.
    static void Sum(int num)
    {
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = (i + 1) * num;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"{num} x {i + 1} = {arr[i]}");
        }
    }
}
