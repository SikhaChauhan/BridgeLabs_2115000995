/* using System;
class BodyMassIdx
{
    // This function finds the BMI of each person
    static void Calc_BMI(double[,] Data)
    {
        for (int i = 0; i < 10; i++)
        {
            double wgt = Data[i, 0];
            double hgtInCm = Data[i, 1];
            double hgtInM = hgtInCm / 100; 
            Data[i, 2] = wgt / (hgtInM * hgtInM);
        }
    }
    // This function determines the BMI status
    static string[] BMIStatus(double[,] Data)
    {
        string[] status = new string[10];
        
        for (int i = 0; i < 10; i++)
        {
            double bmi = Data[i, 2];
            
            if (bmi < 18.5)
                status[i] = "Underweight";
            else if (bmi >= 18.5 && bmi <= 24.9)
                status[i] = "Normal weight";
            else if (bmi >= 25 && bmi <= 29.9)
                status[i] = "Overweight";
            else
                status[i] = "Obesity";
        }
        return status;
    }
    static void Main(string[] args)
    {
        double[,] Data = new double[10, 3];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Enter details for person {i + 1}:");
            
            Console.Write("Enter weight in kg: ");
            Data[i, 0] = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Enter height in cm: ");
            Data[i, 1] = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine();
        }
        Calc_BMI(Data);
        string[] status = BMIStatus(Data);
        Console.WriteLine("BMI and Status for each individual:");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Person {i + 1}:");
            Console.WriteLine($"Weight: {Data[i, 0]} kg");
            Console.WriteLine($"Height: {Data[i, 1]} cm");
            Console.WriteLine($"BMI: {Data[i, 2]:F2}");
            Console.WriteLine($"Status: {status[i]}\n");
        }
    }
}
 */