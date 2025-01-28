using System;
class TrignoFunctions
{
    // The function calculates various trigonometric functions (sin, cos, tan)
    public static double[] CalculateTrigonometricFunctions(double agle)
    {
        double radians = agle * Math.PI / 180;
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        return new double[] { sine, cosine, tangent };
    }

    static void Main(string[] args)
    {
        Console.Write("Enter an angle in degrees: ");
        double agle = Convert.ToDouble(Console.ReadLine());
        double[] res = CalculateTrigonometricFunctions(agle);

        Console.WriteLine($"Sine of {agle}°: {res[0]:F4}");
        Console.WriteLine($"Cosine of {agle}°: {res[1]:F4}");
        Console.WriteLine($"Tangent of {agle}°: {res[2]:F4}");
    }
}
