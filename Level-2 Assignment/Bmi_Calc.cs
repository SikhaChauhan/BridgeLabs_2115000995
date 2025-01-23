using System;
class Bmi_Calc
{
    static void Main(string[] args)
    {
        Console.Write("Enter your weight in kgs: ");
        double wgt = double.Parse(Console.ReadLine());

        Console.Write("Enter your height in cm: ");
        double hgtInCm = double.Parse(Console.ReadLine());

        double hgtInMts = hgtInCm / 100;

        double bmi = Cal_BMI(wgt, hgtInMts);

        string wgtStatus = WgtStatus(bmi);

        Console.WriteLine($"\nYour BMI: {bmi:F2} kg/m^2");
        Console.WriteLine($"Weight Status: {wgtStatus}");
    }

    static double Cal_BMI(double wgt, double hgt)
    {
        return wgt / (hgt * hgt);
    }

    static string WgtStatus(double bmi)
    {
        if (bmi < 18.5)
            return "Underweight";
        else if (bmi >= 18.5 && bmi < 24.9)
            return "Normal weight";
        else if (bmi >= 25 && bmi < 29.9)
            return "Overweight";
        else
            return "Obesity";
    }
}