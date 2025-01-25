using System;
class BMI
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
        double[] wgt = new double[person];
        double[] hgt = new double[person];
        double[] bmi = new double[person];
        string[] status = new string[person];
        for (int i = 0; i < person; i++)
        {
            Console.WriteLine($"Enter details for Person {i + 1}:");
            while (true)
            {
                Console.Write("Enter weight (kg): ");
                if (double.TryParse(Console.ReadLine(), out wgt[i]) && wgt[i] > 0)
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
                Console.Write("Enter height:");
                if (double.TryParse(Console.ReadLine(), out hgt[i]) && hgt[i] > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid height. Please enter a valid positive number.");
                }
            }
            bmi[i] = wgt[i] / (hgt[i] * hgt[i]);
            if (bmi[i] < 18.5)
            {
                status[i] = "Underweight";
            }
            else if (bmi[i] >= 18.5 && bmi[i] < 24.9)
            {
                status[i] = "Normal weight";
            }
            else if (bmi[i] >= 25 && bmi[i] < 29.9)
            {
                status[i] = "Overweight";
            }
            else
            {
                status[i] = "Obesity";
            }
        }

        Console.WriteLine("BMI Calculation Results:");
        for (int i = 0; i < person; i++)
        {
            Console.WriteLine($"Person {i + 1}, Height is {hgt[i]:0.00}, Weight is {wgt[i]:0.0}, BMI is {bmi[i]:0.00}, Status is {status[i]}");
        }
    }
}
