using System;
class BubbleSort
{
    public static void SortMarks(int[] marks)
    {
        int n = marks.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped)
                break;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] marks = new int[n];
        Console.WriteLine("Enter the marks of students:");

        for (int i = 0; i < n; i++)
        {
            marks[i] = int.Parse(Console.ReadLine());
        }

        BubbleSort.SortMarks(marks);

        Console.WriteLine("Sorted marks in ascending order:");
        foreach (int mark in marks)
        {
            Console.Write(mark + " ");
        }
    }
}