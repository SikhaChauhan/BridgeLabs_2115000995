using System;
class Fomat_Date_Time
{
    static void Main(string[] args)
    {
        DateTime currDate = DateTime.Now;
        
        Console.WriteLine("Current Date in different formats:");
        Console.WriteLine("dd/MM/yyyy: " + currDate.ToString("dd/MM/yyyy"));
        Console.WriteLine("yyyy-MM-dd: " + currDate.ToString("yyyy-MM-dd"));
        Console.WriteLine("EEE, MMM dd, yyyy: " + currDate.ToString("ddd, MMM dd, yyyy"));
    }
}
