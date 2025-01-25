using System;
class Age
{
    static void Main(string[] args)
    {
        int[] arr = new int[10];
        Console.WriteLine("Enter the age of all the students: ");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        solution(arr);
    }
    // This function is used to find out whether students can vote or not 
    // depending on their age 
    static void solution(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 18)
            {
                Console.WriteLine($"The student with the age {arr[i]} can vote");
            }
            else
            {
                Console.WriteLine($"The student with the age {arr[i]} cannot vote");
            }
        }
    }
}
