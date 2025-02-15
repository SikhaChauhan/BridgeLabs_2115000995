using System;
class RotationPoint{
    public static int FindRotationPoint(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] > arr[right])
                left = mid + 1;
            else
                right = mid;
        }

        return left;
    }
}
class Program
{
    public static void Main()
    {
        Console.Write("Enter elements of rotated sorted array (space-separated): ");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int rotationIndex = RotationPoint.FindRotationPoint(arr);
        Console.WriteLine($"Rotation Point Index: {rotationIndex}");
        Console.WriteLine($"Smallest Element: {arr[rotationIndex]}");
    }
}