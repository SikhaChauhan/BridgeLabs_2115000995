/* using System;
class PrimeNum
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number to check if it is prime: ");
        int num = int.Parse(Console.ReadLine());

        if (Prime_Check(num))
        {
            Console.WriteLine($"{num} is a Prime Number.");
        }
        else
        {
            Console.WriteLine($"{num} is not a Prime Number.");
        }
    }

    static bool Prime_Check(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

}



 */