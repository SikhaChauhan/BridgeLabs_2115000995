using System;
class Day_Calc
{
    static void Main(string[] args)
    {
        day_check();
    }
    static void day_check(){
	Console.Write("Enter month (1-12): ");
        int mon= int.Parse(Console.ReadLine());
        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());
        Console.Write("Enter year: ");
        int yr = int.Parse(Console.ReadLine());

        int yr_Adjstd = yr - (14 - mon) / 12;
        int leap_fact = yr_Adjstd + yr_Adjstd / 4 - yr_Adjstd / 100 + yr_Adjstd / 400;
        int mon_Adjstd = mon + 12 * ((14 - mon) / 12) - 2;
        int week_Day = (day + leap_fact + 31 * mon_Adjstd / 12) % 7;

        Console.WriteLine($"The day of the week is: {week_Day}");
     }
}
