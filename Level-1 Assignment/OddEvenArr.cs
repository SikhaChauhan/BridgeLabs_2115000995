using System;
class OddEvenArr
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a natural number:");
        if (!int.TryParse(Console.ReadLine(), out int num) || num < 1)
        {
            Console.WriteLine("Error: Please enter a valid natural number (greater than 0).");
            return;
        }
        int[] oddNum, evenNum;
        ProcessNum(num, out oddNum, out evenNum);
        PrintArr("Odd Numbers", oddNum);
        PrintArr("Even Numbers", evenNum);
    }
    // Method to process numbers and separate them into odd and even arrays
    static void ProcessNum(int num, out int[] oddNum, out int[] evenNum)
    {
        oddNum = new int[num / 2 + 1];  
        evenNum = new int[num / 2 + 1]; 
        int oddIdx = 0, evenIdx = 0;
        for (int i = 1; i <= num; i++)  
        {
            if (i % 2 == 0)
            {
                evenNum[evenIdx++] = i; 
            }
            else
            {
                oddNum[oddIdx++] = i; 
            }
        }
        Array.Resize(ref oddNum, oddIdx);
        Array.Resize(ref evenNum, evenIdx);
    }

    // Method to print the contents of an array
    static void PrintArr(string label, int[] arr)
    {
        Console.WriteLine($"{label}:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
