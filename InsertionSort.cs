using System;

class InsertionSort
{
    public static void SortEmployeeIDs(int[] empIDs)
    {
        int n = empIDs.Length;
        for (int i = 1; i < n; i++)
        {
            int key = empIDs[i];
            int j = i - 1;

            while (j >= 0 && empIDs[j] > key)
            {
                empIDs[j + 1] = empIDs[j];
                j--;
            }
            empIDs[j + 1] = key;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of employees: ");
        int n = int.Parse(Console.ReadLine());

        int[] empIDs = new int[n];
        Console.WriteLine("Enter the employee IDs:");

        for (int i = 0; i < n; i++)
        {
            empIDs[i] = int.Parse(Console.ReadLine());
        }

        InsertionSort.SortEmployeeIDs(empIDs); 

        Console.WriteLine("Sorted Employee IDs in ascending order:");
        foreach (int id in empIDs)
        {
            Console.Write(id + " ");
        }
    }
}
