using System;
class Temp_Converter
{
    // Function to convert Fahrenheit to Celsius
    static double Fahren_Celsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Function to convert Celsius to Fahrenheit
    static double Celsius_Fahren(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static void Main()
    {
        int choice;
        double temp;

        Console.WriteLine("Temperature Converter");

        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Convert Fahrenheit to Celsius");
        Console.WriteLine("2. Convert Celsius to Fahrenheit");

        Console.Write("Enter the number corresponding to your choice: ");
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter the temperature in Fahrenheit: ");
            temp = Convert.ToDouble(Console.ReadLine());
            double celsius = Fahren_Celsius(temp);
            Console.WriteLine($"{temp}° Fahrenheit is equal to {celsius}° Celsius.");
        }
        else if (choice == 2)
        {
            Console.Write("Enter the temperature in Celsius: ");
            temp = Convert.ToDouble(Console.ReadLine());
            double fahren = Celsius_Fahren(temp);
            Console.WriteLine($"{temp}° Celsius is equal to {fahren}° Fahrenheit.");
        }
        else
        {
            Console.WriteLine("Invalid choice! Please select a valid option.");
        }
    }
}
