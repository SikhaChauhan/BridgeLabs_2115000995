using System;
class Arithmetic
{
    // Function for addition
    static double add(double a, double b)
    {
        return a + b;
    }

    // Function for subtraction
    static double sub(double a, double b)
    {
        return a - b;
    }

    // Function for multiplication
    static double multi(double a, double b)
    {
        return a * b;
    }

    // Function for division
    static double divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN; 
        }
        return a / b;
    }

    static void Main()
    {
        double num1, num2;
        int choice;

        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        // Display the menu for operation choices
        Console.WriteLine("\nChoose an operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        Console.Write("Enter the number corresponding to the operation: ");
        choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine($"Result: {num1} + {num2} = {add(num1, num2)}");
                break;

            case 2:
                Console.WriteLine($"Result: {num1} - {num2} = {sub(num1, num2)}");
                break;

            case 3:
                Console.WriteLine($"Result: {num1} * {num2} = {multi(num1, num2)}");
                break;

            case 4:
                Console.WriteLine($"Result: {num1} / {num2} = {divide(num1, num2)}");
                break;

            default:
                Console.WriteLine("Invalid choice! Please choose a valid operation.");
                break;
        }
    }
}
