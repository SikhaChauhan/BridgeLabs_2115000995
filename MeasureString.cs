using System;
using System.Text;
using System.Diagnostics;

class MeasureString
{
    public static long MeasureStringConcatenation(int iterations)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        string result = "";
        for (int i = 0; i < iterations; i++)
        {
            result += "a";
        }
        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }

    public static long MeasureStringBuilderConcatenation(int iterations)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            sb.Append("a");
        }
        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }
}

class Program
{
    public static void Main()
    {
        int iterations = 10000;

        Console.WriteLine("Testing performance with " + iterations + " iterations...\n");

        long timeString = MeasureString.MeasureStringConcatenation(iterations); 
        long timeStringBuilder = MeasureString.MeasureStringBuilderConcatenation(iterations);

        Console.WriteLine($"String (+) concatenation time: {timeString} ms");
        Console.WriteLine($"StringBuilder concatenation time: {timeStringBuilder} ms");

        if (timeStringBuilder > 0) 
        {
            Console.WriteLine($"\nStringBuilder is approximately {(double)timeString / timeStringBuilder:F2} times faster.");
        }
        else
        {
            Console.WriteLine("\nStringBuilder execution time is too fast to measure precisely.");
        }
    }
}
