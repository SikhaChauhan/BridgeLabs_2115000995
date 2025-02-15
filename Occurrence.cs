using System;
class Occurrence
{
    public static int FindFirstOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1, result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                right = mid - 1;
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return result;
    }

    public static int FindLastOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1, result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid;
                left = mid + 1;
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return result;
    }
}

class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 2, 2, 3, 4, 5, 5, 6 };

        Console.Write("Enter the target element: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int target))
        {
            int first = Occurrence.FindFirstOccurrence(arr, target);
            int last = Occurrence.FindLastOccurrence(arr, target);

            if (first != -1)
                Console.WriteLine($"First occurrence: {first}, Last occurrence: {last}");
            else
                Console.WriteLine("Element not found in the array.");
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid integer.");
        }
    }
}
