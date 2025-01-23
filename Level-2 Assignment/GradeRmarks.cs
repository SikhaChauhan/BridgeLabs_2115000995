using System;

class GradeRemarks
{
    static void Main(string[] args)
    {
        Console.Write("Enter marks for Physics: ");
        double phy = ValMarks();

        Console.Write("Enter marks for Chemistry: ");
        double chem = ValMarks();

        Console.Write("Enter marks for Maths: ");
        double maths = ValMarks();

        double avg = CalAvg(phy, chem, maths);
        double percen = CalPercen(phy, chem, maths);
        (string grd, string rmrks) = g_and_r(percen);

        Console.WriteLine($"\nAverage Marks: {avg:F2}");
        Console.WriteLine($"Percentage: {percen:F2}%");
        Console.WriteLine($"Grade: {grd}");
        Console.WriteLine($"Remarks: {rmrks}");
    }

    static double ValMarks()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double marks) && marks >= 0 && marks <= 100)
            {
                return marks;
            }
            else
            {
                Console.Write("Invalid input. Please enter marks between 0 and 100: ");
            }
        }
    }

    static double CalAvg(double phy, double chem, double maths)
    {
        return (phy + chem + maths) / 3;
    }

    static double CalPercen(double phy, double chem, double maths)
    {
        return ((phy + chem + maths) / 300) * 100;
    }

    static (string, string) g_and_r(double percen)
    {
        if (percen >= 80)
            return ("A", "Excellent performance");
        else if (percen >= 70)
            return ("B", "Good performance");
        else if (percen >= 60)
            return ("C", "Satisfactory performance");
        else if (percen >= 50)
            return ("D", "Needs improvement");
        else if (percen >= 40)
            return ("E", "Barely passing");
        else
            return ("R", "Remedial action required");
    }
}
