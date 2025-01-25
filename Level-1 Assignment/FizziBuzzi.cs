using System;
class FizziBuzzi
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num <= 0)
        {
            Console.WriteLine("Invalid Input. Please enter a positive integer.");
            return;
        }

        string[] res = GRateBuzzRes(num);
        PrintRes(res);
    }
    // This function generates fizzbuzz results
    static string[] GRateBuzzRes(int num)
    {
        string[] res = new string[num + 1];

        for (int i = 1; i <= num; i++) 
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                res[i] = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                res[i] = "Fizz";
            }
            else if (i % 5 == 0)
            {
                res[i] = "Buzz";
            }
            else
            {
                res[i] = i.ToString();
            }
        }
        return res;
    }
    // This function prints the results with position
    static void PrintRes(string[] resArr)
    {
        Console.WriteLine("FizzBuzz Results:");
        for (int i = 1; i < resArr.Length; i++)  1
        {
            Console.WriteLine($"Position {i} = {resArr[i]}");
        }
    }
}
