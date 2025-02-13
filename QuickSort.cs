using System;
class QuickSort
{
    public static void SortProductPrices(int[] prices, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(prices, low, high);
            SortProductPrices(prices, low, pivotIndex - 1);
            SortProductPrices(prices, pivotIndex + 1, high);
        }
    }

    private static int Partition(int[] prices, int low, int high)
    {
        int pivot = prices[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (prices[j] < pivot)
            {
                i++;
                Swap(ref prices[i], ref prices[j]);
            }
        }
        Swap(ref prices[i + 1], ref prices[high]);
        return i + 1;
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
        Console.Write("Enter the number of product prices: ");
        int n = int.Parse(Console.ReadLine());

        int[] productPrices = new int[n];
        Console.WriteLine("Enter the product prices:");

        for (int i = 0; i < n; i++)
        {
            productPrices[i] = int.Parse(Console.ReadLine());
        }

        QuickSort.SortProductPrices(productPrices, 0, productPrices.Length - 1); 

        Console.WriteLine("Sorted Product Prices in ascending order:");
        foreach (int price in productPrices)
        {
            Console.Write(price + " ");
        }
    }
}
