using System;
class CountingSort
{
    public static void SortStudentAges(int[] ages, int minAge, int maxAge)
    {
        int range = maxAge - minAge + 1;
        int[] count = new int[range];
        int[] output = new int[ages.Length];
        for (int i = 0; i < ages.Length; i++)
        {
            count[ages[i] - minAge]++;
        }

        for (int i = 1; i < range; i++)
        {
            count[i] += count[i - 1];
        }

        for (int i = ages.Length - 1; i >= 0; i--)
        {
            output[count[ages[i] - minAge] - 1] = ages[i];
            count[ages[i] - minAge]--;
        }

        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = output[i];
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] ages = new int[n];
        Console.WriteLine("Enter the ages of students (between 10 and 18):");

        for (int i = 0; i < n; i++)
        {
            ages[i] = int.Parse(Console.ReadLine());
            if (ages[i] < 10 || ages[i] > 18)
            {
                Console.WriteLine("Invalid age! Enter an age between 10 and 18.");
                i--;
            }
        }

        CountingSort.SortStudentAges(ages, 10, 18); 
        Console.WriteLine("Sorted Student Ages:");
        foreach (int age in ages)
        {
            Console.Write(age + " ");
        }
    }
}
