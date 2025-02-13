
using System;
class SelectionSort
{
    public static void SortExamScores(int[] scores)
    {
        int n = scores.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (scores[j] < scores[minIndex])
                {
                    minIndex = j;
                }
            }

            Swap(ref scores[minIndex], ref scores[i]);
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
        Console.Write("Enter the number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] examScores = new int[n];
        Console.WriteLine("Enter the exam scores:");

        for (int i = 0; i < n; i++)
        {
            examScores[i] = int.Parse(Console.ReadLine());
        }

        SelectionSort.SortExamScores(examScores);
        Console.WriteLine("Sorted Exam Scores in ascending order:");
        foreach (int score in examScores)
        {
            Console.Write(score + " ");
        }
    }
}

