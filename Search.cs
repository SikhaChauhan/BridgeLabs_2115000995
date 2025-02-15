using System;
class Search{
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
        return -1;     }

}
class Program
{
    public static void Main()
    {
        int[] arr = { 8, 3, 10, 4, 1, 6, -5 };
        Array.Sort(arr);
        Console.WriteLine("Sorted Array: " + string.Join(", ", arr));

        Console.Write("Enter the target number: ");
        int target = int.Parse(Console.ReadLine());

        int index = Search.BinarySearch(arr, target);

        if (index != -1)
            Console.WriteLine($"Target {target} found at index {index}.");
        else
            Console.WriteLine(Search.BinarySearch(arr, target));
    }
}
