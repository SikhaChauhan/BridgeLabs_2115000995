//Q2.Write a program that takes two numbers as input from the user and prints their sum.


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = num1 + num2;

        Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
    }
}

