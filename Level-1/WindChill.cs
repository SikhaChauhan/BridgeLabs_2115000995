/* using System;
class WindChill
{
    // This function calculates the wind chill temperature
    public static double Calc_WindChill(double temp, double w_Speed)
    {
        double w_Chill = 35.74 + (0.6215 * temp) + ((0.4275 * temp - 35.75) * Math.Pow(w_Speed, 0.16));
        return w_Chill;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter the temperature in Fahrenheit: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the wind speed in miles per hour: ");
        double w_Speed = Convert.ToDouble(Console.ReadLine());

        double w_Chill = Calc_WindChill(temp, w_Speed);

        Console.WriteLine($"The wind chill temperature is: {w_Chill:F2}°F");
    }
}
 */