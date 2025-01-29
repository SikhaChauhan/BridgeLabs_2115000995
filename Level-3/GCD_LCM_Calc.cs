using System;
class GCD_LCM_Calc
{
    // Function to calculate the GCD
    static int GCD(int x, int y)
    {
        while (y != 0)
        {
            int temp = y;
            y = x % y;
            x = temp;
        }
        return x;
    }

    // Function to calculate the LCM
    static int LCM(int x, int y)
    {
        return (x * y) / GCD(x, y); 
    }

    static void Main()
    {
        int num1, num2;
        Console.Write("Enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        int gcd = GCD(num1, num2);
        int lcm = LCM(num1, num2);

        Console.WriteLine($"The Greatest Common Divisor (GCD) of {num1} and {num2} is: {gcd}");
        Console.WriteLine($"The Least Common Multiple (LCM) of {num1} and {num2} is: {lcm}");
    }
}
