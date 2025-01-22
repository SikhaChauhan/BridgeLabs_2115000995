using System;

class TemperatureCelsius
{
    static void Main(string[] args)
    {
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine() ?? "0");
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"The {celsius} Celsius is {fahrenheit} Fahrenheit");
    }
}
