using System;
class BonusProg
{
    static void Main(string[] args)
    {
        CalculateBonus();
    }
//  This function calculates bonus, salary, and display output
    static void CalcBonus()
    {
        int numEmploy = 10;
        double[] oldSal = new double[numEmploy];
        double[] yrsOfServe = new double[numEmploy];
        double[] bonus = new double[numEmploy];
        double[] newSal = new double[numEmploy];
        double ttlBonus = 0;
        double ttlOldSal = 0;
        double ttlNewSal = 0;
        for (int i = 0; i < numEmploy; i++)
        {
            Console.WriteLine($"Enter details for Employee {i + 1}:");
            while (true)
            {
                Console.Write("Enter salary: ");
                if (double.TryParse(Console.ReadLine(), out oldSal[i]) && oldSal[i] > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid salary. Please enter a valid positive salary.");
                }
            }
            while (true)
            {
                Console.Write("Enter years of service: ");
                if (double.TryParse(Console.ReadLine(), out yrsOfServe[i]) && yrsOfServe[i] >= 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid years of service. Please enter a valid non-negative number.");
                }
            }
        }
        for (int i = 0; i < numEmploy; i++)
        {
            if (yrsOfServe[i] > 5)
            {
                bonus[i] = oldSal[i] * 0.05; 
            }
            else
            {
                bonus[i] = oldSal[i] * 0.02; 
            }
            newSal[i] = oldSal[i] + bonus[i];
            ttlBonus += bonus[i];
            ttlOldSal += oldSal[i];
            ttlNewSal += newSal[i];
        }
        Console.WriteLine("\nTotal Bonus Payout: " + ttlBonus);
        Console.WriteLine("Total Old Salary: " + ttlOldSal);
        Console.WriteLine("Total New Salary: " + ttlNewSal);
    }
}
