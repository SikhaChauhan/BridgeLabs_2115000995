using System;
class HarshadNum
{
    static void Main()
    {
        numCheck();
	}
	static void numCheck(){
		Console.Write("Enter a number: ");
        int harshad_Num = int.Parse(Console.ReadLine());
        int sum_Digits = 0;
		int	temp = harshad_Num;
        while (temp != 0)
        {
            sum_Digits += temp % 10;
            temp /= 10;
        }
        if (harshad_Num % sum_Digits == 0)
            Console.WriteLine($"{harshad_Num} is a Harshad Number.");
        else{
            Console.WriteLine($"{harshad_Num} is not a Harshad Number.");
		}
	}
}

