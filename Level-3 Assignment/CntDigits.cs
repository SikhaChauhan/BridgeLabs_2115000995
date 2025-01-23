using System;
class CntDigits
{
    static void Main()
    {
        cnt_digits(string[] args);
    }
	static void cnt_digits(){
	Console.Write("Enter a number: ");
        int user_Ipt = int.Parse(Console.ReadLine());
        int digit_Cnt = 0;

        while (user_Ipt != 0)
        {
            user_Ipt /= 10;
            digit_Cnt++;
        }
        Console.WriteLine($"The number of digits is: {digit_Cnt}");
	}
}
