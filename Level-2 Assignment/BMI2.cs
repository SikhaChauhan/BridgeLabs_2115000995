using System;
class BMI2
{
    static void Main(string[] args)
    {
        CalcBMI();
    }
    // This function calculates BMI and displays height, weight, BMI, and status for each person
    static void CalcBMI()
    {
        int person;
        Console.Write("Enter the number of persons: ");
        while (!int.TryParse(Console.ReadLine(), out person) || person <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid number of persons.");
            Console.Write("Enter the number of persons: ");
        }
        double[,] personData = new double[person, 3]; 
        string[] wgtStatus = new string[person];   
        for (int i = 0; i < person; i++)
        {
            Console.WriteLine($"Enter details for Person {i + 1}:");
            while (true)
            {
                Console.Write("Enter weight (kg): ");
                if (double.TryParse(Console.ReadLine(), out personData[i, 0]) && personData[i, 0] > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid weight. Please enter a valid positive number.");
                }
            }
            while (true)
            {
                Console.Write("Enter height: ");
                if (double.TryParse(Console.ReadLine(), out personData[i, 1]) && personData[i, 1] > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid height. Please enter a valid positive number.");
                }
            }
            personData[i, 2] = personData[i, 0] / (personData[i, 1] * personData[i, 1]);
            if (personData[i, 2] < 18.5)
            {
                wgtStatus[i] = "Underweight";
            }
            else if (personData[i, 2] >= 18.5 && personData[i, 2] < 24.9)
            {
                wgtStatus[i] = "Normal weight";
            }
            else if (personData[i, 2] >= 25 && personData[i, 2] < 29.9)
            {
                wgtStatus[i] = "Overweight";
            }
            else
            {
                wgtStatus[i] = "Obesity";
            }
        }
        Console.WriteLine("BMI Calculation Results:");
        for (int i = 0; i < person; i++)
        {
			Console.WriteLine("Person {i + 1} Height is {personData[i, 1]:0.00}, Weight is {personData[i, 0]:0.0}, BMI is {personData[i, 2]:0.00}, Status {wgtStatus[i]}");
        }
    }
}
