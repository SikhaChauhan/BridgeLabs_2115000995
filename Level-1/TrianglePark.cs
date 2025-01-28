/* using System;
class TrianglePark
{
    // This function calculates the perimeter of the triangular park
    static double Calc_Peri(double s1, double s2, double s3)
    {
        return s1 + s2 + s3;
    }
    // This function calculates the number of rounds needed
    static int Calc_Rds(double peri, double tl_Dist)
    {
        return (int)Math.Ceiling(tl_Dist/ peri);
    }
    static void Main(string[] args)
    {
        Console.Write("Enter the length of side 1 (in meters): ");
        double s1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 2 (in meters): ");
        double s2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of side 3 (in meters): ");
        double s3 = Convert.ToDouble(Console.ReadLine());
        double peri = Calc_Peri(s1, s2, s3);
        double tl_Dist = 5000;
        int rds = Calc_Rds(peri, tl_Dist);
        Console.WriteLine($"The athlete needs to complete {rds} rounds to finish a 5 km run.");
    }
}
 */