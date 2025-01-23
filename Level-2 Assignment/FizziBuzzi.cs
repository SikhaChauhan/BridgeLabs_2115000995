using System;

class FizziBuzzi
{
    static void Main(string[] args)
    {
        fizzibuzzi();
    }
    static void fizzibuzzi()
    {
        Console.Write("Enter a positive integer: ");
        string input = Console.ReadLine();
        if (!int.TryParse(input, out int num) || num <= 0)
        {
            Console.WriteLine("Please enter a valid positive integer!");
            return;
        }
        for (int i = 1; i <= num; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
