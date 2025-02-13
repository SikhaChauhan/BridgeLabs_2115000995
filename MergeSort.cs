using System;

class MergeSort
{
    public static void SortBookPrices(int[] prices, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            SortBookPrices(prices, left, mid);
            SortBookPrices(prices, mid + 1, right);
            Merge(prices, left, mid, right);
        }
    }

    private static void Merge(int[] prices, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArr = new int[n1];
        int[] rightArr = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArr[i] = prices[left + i];

        for (int j = 0; j < n2; j++)
            rightArr[j] = prices[mid + 1 + j];

        int iIndex = 0, jIndex = 0, k = left;

        while (iIndex < n1 && jIndex < n2)
        {
            if (leftArr[iIndex] <= rightArr[jIndex])
            {
                prices[k] = leftArr[iIndex];
                iIndex++;
            }
            else
            {
                prices[k] = rightArr[jIndex];
                jIndex++;
            }
            k++;
        }

        while (iIndex < n1)
        {
            prices[k] = leftArr[iIndex];
            iIndex++;
            k++;
        }

        while (jIndex < n2)
        {
            prices[k] = rightArr[jIndex];
            jIndex++;
            k++;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of book prices: ");
        int n = int.Parse(Console.ReadLine());

        int[] bookPrices = new int[n];
        Console.WriteLine("Enter the book prices:");

        for (int i = 0; i < n; i++)
        {
            bookPrices[i] = int.Parse(Console.ReadLine());
        }

        MergeSort.SortBookPrices(bookPrices, 0, bookPrices.Length - 1);

        Console.WriteLine("Sorted Book Prices in ascending order:");
        foreach (int price in bookPrices)
        {
            Console.Write(price + " ");
        }
    }
}
