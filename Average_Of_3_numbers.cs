//Q9.Write a program that takes three numbers as input from the user and prints their average.


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the third number: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double average = (num1 + num2 + num3) / 3;

        Console.WriteLine($"The average of the three numbers is {average}");
    }
}
