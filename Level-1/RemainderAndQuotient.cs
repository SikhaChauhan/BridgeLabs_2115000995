using System;
class RemainderAndQuotient
{
    // This function finds the remainder and quotient of two numbers
    public static int[] FindRemainderAndQuotient(int num, int divi)
    {
        int quoti = num / divi;  
        int remai = num % divi; 
        return new int[] { quoti, remai };
    }
    static void Main(string[] args)
    {
        // Take user input for the number and divisor
        Console.Write("Enter the number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divi = Convert.ToInt32(Console.ReadLine());
        if (divi == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return;
        }

        // Call the method to find quotient and remainder
        int[] res = FindRemainderAndQuotient(num, divi);

        // Display the quotient and remainder
        Console.WriteLine($"The quotient is: {res[0]}");
        Console.WriteLine($"The remainder is: {res[1]}");
    }
}
