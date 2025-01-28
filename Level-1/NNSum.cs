using System;
class NNSum
{
    // This function calculates the sum of n natural numbers
    static int NaturalNumSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer (n): ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n < 1)
        {
            Console.WriteLine("Please enter a positive integer greater than 0.");
            return;
        }
        int res = NaturalNumSum(n);
        Console.WriteLine($"The sum of the first {n} natural numbers is: {res}");
    }
}
