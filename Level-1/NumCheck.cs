using System;
class NumCheck
{
    // This function determines if the number is positive, negative, or zero
    static int CheckNumber(int number)
    {
        if (num > 0)
            return 1; 
        else if (num < 0)
            return -1; 
        else
            return 0; 
    }
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int res = CheckNum(num);
        if (res == 1)
            Console.WriteLine("The number is positive.");
        else if (res == -1)
            Console.WriteLine("The number is negative.");
        else
            Console.WriteLine("The number is zero.");
    }
}
