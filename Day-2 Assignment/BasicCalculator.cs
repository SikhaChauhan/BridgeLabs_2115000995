using System;
class BasicCalculator {
    public static void Main(string[] args) {
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = number1 / number2;
        Console.WriteLine($"The addition, subtraction, multiplication and division of numbers {number1} and {number2} are {addition}, {subtraction}, {multiplication}, and {division}");
    }
}

