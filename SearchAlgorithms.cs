
using System;

class SearchAlgorithms
{
    public static int FindFirstMissingPositive(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            while (arr[i] > 0 && arr[i] <= n && arr[arr[i] - 1] != arr[i])
            {
                int temp = arr[arr[i] - 1];
                arr[arr[i] - 1] = arr[i];
                arr[i] = temp;
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (arr[i] != i + 1)
                return i + 1;
        }

        return n + 1;
    }

    public static int BinarySearch(int[] sortedArr, int target)
    {
        int left = 0, right = sortedArr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (sortedArr[mid] == target)
                return mid;
            else if (sortedArr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
}

class Program
{
    public static void Main()
    {
        int[] arr = { 3, 4, -1, 1, 7, 2, 5 };
        int[] arrCopy = (int[])arr.Clone();
        int missing = SearchAlgorithms.FindFirstMissingPositive(arrCopy);
        Console.WriteLine($"First missing positive integer: {missing}");
        Array.Sort(arr);
        Console.WriteLine("Sorted Array: " + string.Join(", ", arr));

        Console.Write("Enter the target number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int target))
        {
            int index = SearchAlgorithms.BinarySearch(arr, target);
            if (index != -1)
                Console.WriteLine($"Target {target} found at sorted index {index}.");
            else
                Console.WriteLine($"Target {target} not found in the array.");
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid integer.");
        }
    }
}

