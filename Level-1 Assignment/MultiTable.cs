using System;
class MultiTable
{
	static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        multiply(num);
    }
    // This function is used to print the multiplication table of a number
    static void multiply(int num)
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
