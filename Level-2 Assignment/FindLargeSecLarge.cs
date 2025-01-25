using System;
class FindLargeSecLarge
{
    static void Main(string[] args)
    {
        FindLarSecLarDigit();
    }
	// This Function finds the largest and second-largest digits
    static void FindLarSecLarDigit()
    {
        int num;
        int maxDigit = 10;  
        int[] digits = new int[maxDigit];  
        int idx = 0;  
        Console.Write("Enter a number: ");
        while (!int.TryParse(Console.ReadLine(), out num) || num < 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number.");
            Console.Write("Enter a number: ");
        }
        while (num != 0)
        {
            digits[idx] = num % 10;
            num /= 10;  
            idx++; 
            if (idx == maxDigit)
            {
                break;
            }
        }
        int lar = 0;
        int secLar = 0;
        for (int i = 0; i < idx; i++)
        {
            if (digits[i] > lar)
            {
                secLar = lar;
                lar = digits[i];
            }
            else if (digits[i] > secLar && digits[i] != lar)
            {
                secLar = digits[i];
            }
        }
        if (lar == secLar)
        {
            Console.WriteLine("There is no second largest digit as all digits are the same.");
        }
        else
        {
            Console.WriteLine($"Largest digit: {lar}");
            Console.WriteLine($"Second largest digit: {secLar}");
        }
    }
}
