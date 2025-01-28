using System;
class SI
{
	static void Main(string[] args)
	{
		Console.Write("Enter the Principal amount: ");
        double pri = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Rate of interest (in %): ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());
        double s_i = CalcSI(pri, rate, time);
        Console.WriteLine($"The Simple Interest is {s_i:F2} for Principal {pri}, Rate of Interest {rate}% and Time {time} years.");
    }

     // This function calculates the Simple Interest
    static double CalcSI(double pri, double rate, double time)
    {
         return (pri * rate * time) / 100;
    }
 }
