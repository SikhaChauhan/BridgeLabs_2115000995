using System;
class PeakElement
{
    public static int FindPeakElement(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] > arr[mid + 1])
                right = mid;
            else
                left = mid + 1;
        }

        return left;
    }

    public static void Main()
    {
        Console.Write("Enter elements of the array (space-separated): ");
        string input = Console.ReadLine();

        try
        {
            int[] arr = Array.ConvertAll(
                input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries),
                s => int.Parse(s.Trim())             );

            if (arr.Length == 0)
            {
                Console.WriteLine("Error: The array cannot be empty.");
                return;
            }

            int peakIndex = PeakElement.FindPeakElement(arr);
            Console.WriteLine($"Peak Element Index: {peakIndex}");
            Console.WriteLine($"Peak Element: {arr[peakIndex]}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter only integers separated by spaces.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Unexpected error: {e.Message}");
        }
    }
}