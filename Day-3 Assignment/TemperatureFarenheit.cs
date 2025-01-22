using System;

class TemperatureFarenheit
{
    static void Main(string[] args)
    {
        Console.Write("Enter the temperature in Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine() ?? "0");
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsius} Celsius");
    }
}
