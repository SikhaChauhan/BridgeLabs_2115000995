using System;
class FriendsRes
{
    static void Main(string[] args)
    {
        FindNow();
    }
// This function finds the youngest and tallest among the friends
    static void FindNow()
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] hgts = new double[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter the age of {names[i]}: ");
            while (!int.TryParse(Console.ReadLine(), out ages[i]) || ages[i] <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive age.");
                Console.Write($"Enter the age of {names[i]}: ");
            }

            Console.Write($"Enter the height of {names[i]} (in meters): ");
            while (!double.TryParse(Console.ReadLine(), out hgts[i]) || hgts[i] <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid positive height.");
                Console.Write($"Enter the height of {names[i]}: ");
            }
        }
        int youngIdx = 0;
        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngIdx])
            {
                youngIdx = i;
            }
        }
        int tallIdx = 0;
        for (int i = 1; i < 3; i++)
        {
            if (hgts[i] > hgts[tallIdx])
            {
                tallIdx = i;
            }
        }
        Console.WriteLine($"\nThe youngest friend is {names[youngIdx]} with age {ages[youngIdx]}.");
        Console.WriteLine($"The tallest friend is {names[tallIdx]} with height {hgts[tallIdx]} meters.");
    }
}
