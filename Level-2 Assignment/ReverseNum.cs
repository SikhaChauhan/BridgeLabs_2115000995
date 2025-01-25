using System;
class ReverseNum
{
    static void Main(string[] args)
    {
        RevNum();
    }
    // This function takes input, stores digits in an array, and displays them in reverse order
    static void RevNum()
    {
        int num;
        Console.Write("Enter a number: ");
        while (!int.TryParse(Console.ReadLine(), out num) || num < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number.");
            Console.Write("Enter a number: ");
        }
        int cnt = 0;
        int temp = num;
        while (temp != 0)
        {
            temp /= 10;
            cnt++;
        }
        int[] digits = new int[cnt];
        temp = num;
        for (int i = 0; i < count; i++)
        {
            digits[i] = temp % 10;
            temp /= 10;
        }
        int[] revDigits = new int[cnt];
        for (int i = 0; i < cnt; i++)
        {
            revDigits[i] = digits[cnt - i - 1];
        }
        Console.WriteLine("Reversed number is: ");
        for (int i = 0; i < cnt; i++)
        {
            Console.Write(revDigits[i]);
        }
        Console.WriteLine();
    }
}
