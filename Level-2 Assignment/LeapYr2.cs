using System;
class LeapYr2
{
    static void Main(string[] args)
    {
        Console.Write("Enter a Year: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int year))
        {
            l_yr(year);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric year.");
        }
    }
    static void l_yr(int yr)
    {
        if ((yr % 4 == 0 && yr % 100 != 0) || (yr % 400 == 0))
        {
            Console.WriteLine($"{yr} is a leap year.");
        }
        else
        {
            Console.WriteLine($"{yr} is not a leap year.");
        }
    }
}
