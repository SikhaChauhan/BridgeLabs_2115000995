using System;

class PoundsToKgs
{
    static void Main(string[] args)
    {
        Console.Write("Enter the weight (in pounds): ");
        double weightInPounds = double.Parse(Console.ReadLine());
        double weightInKg = weightInPounds / 2.2;
        Console.WriteLine($"The weight of the person in pounds is {weightInPounds} and in kgs is {weightInKg:F2}");
    }
}
