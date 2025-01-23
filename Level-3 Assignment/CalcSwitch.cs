using System;

class CalcSwitch
{
    static void Main()
    {
        calc_switch();
    }
	static void calc_switch(){
		Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("Enter operator (+, -, *, /): ");
        string operation = Console.ReadLine();

        switch (operation)
        {
            case "+":
                Console.WriteLine($"Result: {num1 + num2}");
                break;
            case "-":
                Console.WriteLine($"Result: {num1 - num2}");
                break;
            case "*":
                Console.WriteLine($"Result: {num1 * num2}");
                break;
            case "/":
                if (num2 != 0)
                    Console.WriteLine($"Result: {num1 / num2}");
                else
                    Console.WriteLine("Error: Division by zero.");
                break;
            default:
                Console.WriteLine("Invalid Operator.");
                break;
        }
	}
}
