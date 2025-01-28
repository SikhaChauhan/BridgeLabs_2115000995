/* using System;
class FootballTeam
{
    // This function generates random heights for players
    static int[] Generate_Hgts(int size, int min, int max)
    {
        Random ran_dom = new Random();
        int[] hgts = new int[size];
        for (int i = 0; i < size; i++)
        {
            hgts[i] = ran_dom.Next(min, max + 1);
        }
        return hgts;
    }

    // This function calculates the sum of elements in an array
    static int Calc_Sum(int[] hgts)
    {
        return hgts.Sum();
    }

    // This function calculates the mean height
    static double Calc_Mean(int[] hgts)
    {
        int sum = Calc_Sum(hgts);
        return (double)sum / hgts.Length;
    }

    // This function finds the shortest height
    static int Shortest_Hgt(int[] hgts)
    {
        return hgts.Min();
    }

    // This function finds the tallest height
    static int Tallest_Hgt(int[] hgts)
    {
        return hgts.Max();
    }
    static void Main(string[] args)
    {
        int[] hgts = Generate_Hgts(11, 150, 250);
        int sum = Calc_Sum(hgts);
        double mean = Calc_Mean(hgts);
        int short_est = Shortest_Hgt(hgts);
        int tall_est = Tallest_Hgt(hgts);

        Console.WriteLine("Heights of players (in cms): " + string.Join(", ", hgts));
        Console.WriteLine($"Total sum of heights: {sum} cms");
        Console.WriteLine($"Mean height: {mean:F2} cms");
        Console.WriteLine($"Shortest height: {short_est} cms");
        Console.WriteLine($"Tallest height: {tall_est} cms");
    }
}
 */