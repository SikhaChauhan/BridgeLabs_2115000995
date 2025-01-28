using System;
class Spring_Season
{
    // This function checks if the date is in Spring Season
    static bool Spri_Season(int mon_th, int day)
    {
        if ((mon_th == 3 && day >= 20) ||  
            (mon_th > 3 && mon_th < 6) ||  
            (mon_th == 6 && day <= 20))   
        {
            return true;
        }
        return false;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter the month (1-12): ");
        int mon_th = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the day: ");
        int day = Convert.ToInt32(Console.ReadLine());

        if (mon_th < 1 || mon_th > 12 || day < 1 || day > 31)
        {
            Console.WriteLine("Invalid date input.");
            return;
        }
        bool is_Spring = Spri_Season(mon_th, day);
        if (is_Spring)
            Console.WriteLine("It's a Spring Season.");
        else
            Console.WriteLine("Not a Spring Season.");
    }
}
