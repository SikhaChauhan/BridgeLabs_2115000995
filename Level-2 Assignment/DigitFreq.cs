using System;
class DigitFreq
{
    static void Main(string[] args)
    {
        FindDigitFreq();
    }
    // This function calculates and displays the frequency of each digit in a non-negative integer input by the user.
    static void FindDigitFreq()
    {
        Console.Write("Enter a number: ");
        string inp = Console.ReadLine();
        long num;

        while (!long.TryParse(input, out num) || num < 0)
        {
            Console.WriteLine("Invalid input. Please enter a non-negative number.");
            Console.Write("Enter a number: ");
            inp = Console.ReadLine();
        }

        int[] freq = new int[10];

        foreach (char digit in inp)
        {
            int currDigit = digit - '0';
            freq[currDigit]++;
        }

        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (freq[i] > 0)
            {
                Console.WriteLine($"Digit {i}: {freq[i]} time(s)");
            }
        }
    }
}
