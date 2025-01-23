using System;
class FrndsCompare
{
    static void Main(string[] args)
    {
        Console.Write("Enter Amar's age: ");
        int amar_Age = int.Parse(Console.ReadLine());
        Console.Write("Enter Amar's height in cm: ");
        double amar_Hgt = double.Parse(Console.ReadLine());
		
        Console.Write("Enter Akbar's age: ");
        int akbar_Age = int.Parse(Console.ReadLine());
        Console.Write("Enter Akbar's height in cm: ");
        double akbar_Hgt = double.Parse(Console.ReadLine());

        Console.Write("Enter Anthony's age: ");
        int anthony_Age = int.Parse(Console.ReadLine());
        Console.Write("Enter Anthony's height in cm: ");
        double anthony_Hgt = double.Parse(Console.ReadLine());

        string ygst = find_ygst(amar_Age, akbar_Age, anthony_Age);

        string tlst = find_tlst(amar_Hgt, akbar_Hgt, anthony_Hgt);

        Console.WriteLine($"\nThe youngest friend is: {ygst}");
        Console.WriteLine($"The tallest friend is: {tlst}");
    }

	static string find_ygst(int amar_Age, int akbar_Age, int anthony_Age)
    {
        int min_Age = Math.Min(amar_Age, Math.Min(akbar_Age, anthony_Age));
        
        if (min_Age == amar_Age)
            return "Amar";
        else if (min_Age == akbar_Age)
            return "Akbar";
        else
            return "Anthony";
    }

    static string find_tlst(double amar_Hgt, double akbar_Hgt, double anthony_Hgt)
    {
        double max_Hgt = Math.Max(amar_Hgt, Math.Max(akbar_Hgt, anthony_Hgt));
        
        if (max_Hgt == amar_Hgt)
            return "Amar";
        else if (max_Hgt == akbar_Hgt)
            return "Akbar";
        else
            return "Anthony";
    }
}