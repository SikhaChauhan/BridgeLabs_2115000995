using System;
class HeapSort
{
    public static void SortSalaries(int[] salaries)
    {
        int n = salaries.Length;
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(salaries, n, i);
        }

        for (int i = n - 1; i > 0; i--)
        {
            Swap(ref salaries[0], ref salaries[i]);
            Heapify(salaries, i, 0);
        }
    }

    private static void Heapify(int[] arr, int n, int i)
    {
        int largest = i; 
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && arr[left] > arr[largest])
        {
            largest = left;
        }

        if (right < n && arr[right] > arr[largest])
        {
            largest = right;
        }

        if (largest != i)
        {
            Swap(ref arr[i], ref arr[largest]);
            Heapify(arr, n, largest);
        }
    }

    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of applicants: ");
        int n = int.Parse(Console.ReadLine());

        int[] salaries = new int[n];
        Console.WriteLine("Enter the expected salaries:");

        for (int i = 0; i < n; i++)
        {
            salaries[i] = int.Parse(Console.ReadLine());
        }

        HeapSort.SortSalaries(salaries); 
        Console.WriteLine("Sorted Salaries in ascending order:");
        foreach (int salary in salaries)
        {
            Console.Write(salary + " ");
        }
    }
}

