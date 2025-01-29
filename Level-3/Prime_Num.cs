using System;
class Prime_Num
{
    // Function to check if a number is prime
    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false; 
        }
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        bool res = IsPrime(num);
        if (res)
        {
            Console.WriteLine($"{num} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{num} is not a prime number.");
        }
    }
}
