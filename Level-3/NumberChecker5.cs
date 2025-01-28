/* using System;
class NumberChecker5
{
    // This function finds factors of a number and return them as an array
    public static int[] Find_Factors(int num)
    {
        int cnt = 0;
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
                cnt++;
        }

        int[] fact_ors = new int[cnt];
        int idx = 0;
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
                fact_ors[idx++] = i;
        }

        return fact_ors;
    }

    // This function finds the greatest factor of a number
    public static int Greatest_Factor(int[] fact_ors)
    {
        int great_est = fact_ors[0];
        foreach (int factor in fact_ors)
        {
            if (factor > great_est)
                great_est = factor;
        }
        return great_est;
    }

    // This function finds the sum of the factors
    public static int Sum_Factors(int[] fact_ors)
    {
        int sum = 0;
        foreach (int factor in fact_ors)
        {
            sum += factor;
        }
        return sum;
    }

    // This function finds the product of the factors
    public static int Product_Factors(int[] fact_ors)
    {
        int prod_uct = 1;
        foreach (int factor in fact_ors)
        {
            prod_uct *= factor;
        }
        return prod_uct;
    }

    // This function finds the product of the cube of the factors
    public static double Product_Cube_Factors(int[] fact_ors)
    {
        double prod_uct = 1;
        foreach (int factor in fact_ors)
        {
            prod_uct *= Math.Pow(factor, 3);
        }
        return prod_uct;
    }

    // Method to check if a number is a perfect number
    public static bool Perfect_Num(int num)
    {
        int[] fact_ors = Find_Factors(num);
        int sum = Sum_Factors(fact_ors) - num; 
        return sum == num;
    }

    // This function check if a number is an abundant number
    public static bool Abundant_Num(int num)
    {
        int[] fact_ors = Find_Factors(num);
        int sum = Sum_Factors(fact_ors) - num; 
        return sum > num;
    }

    // This function check if a number is a deficient number
    public static bool Deficient_Num(int num)
    {
        int[] fact_ors = Find_Factors(num);
        int sum = Sum_Factors(fact_ors) - num; 
        return sum < num;
    }

    // Method to check if a number is a strong number
    public static bool Strong_Num(int num)
    {
        int orig_inal = num;
        int sum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            sum += Fact_orial(digit);
            num /= 10;
        }

        return sum == orig_inal;
    }

    // This function calculates factorial
    private static int Fact_orial(int num)
    {
        if (num <= 1)
            return 1;
        return num * Fact_orial(num - 1);
    }

    // Main method to test the utility class
    public static void Main(string[] args)
    {
        Console.WriteLine($"Enter Test Number:");
        int test_Num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Number: {test_Num}");
        int[] fact_ors = Find_Factors(test_Num);
        Console.WriteLine($"Factors: {string.Join(", ", fact_ors)}");
        Console.WriteLine($"Greatest Factor: {Greatest_Factor(fact_ors)}");
        Console.WriteLine($"Sum of Factors: {Sum_Factors(fact_ors)}");
        Console.WriteLine($"Product of Factors: {Product_Factors(fact_ors)}");
        Console.WriteLine($"Product of Cube of Factors: {Product_Cube_Factors(fact_ors)}");
        Console.WriteLine($"Is Perfect Number: {Perfect_Num(test_Num)}");
        Console.WriteLine($"Is Abundant Number: {Abundant_Num(test_Num)}");
        Console.WriteLine($"Is Deficient Number: {Deficient_Num(test_Num)}");
        Console.WriteLine($"Is Strong Number: {Strong_Num(test_Num)}");
    }
}
 */