using System;
class Fibo_Seq
{
    // Function to generate and print the Fibonacci sequence up to the specified number of terms
    static void Generate_Fibo(int terms)
    {
        int first = 0, sec = 1, next;
        if (terms <= 0)
        {
            Console.WriteLine("Please enter a positive integer greater than 0.");
            return;
        }
        if (terms >= 1)
        {
            Console.Write(first);
            if (terms > 1) Console.Write(", ");
        }
        if (terms >= 2)
        {
            Console.Write(sec);
            if (terms > 2) Console.Write(", ");
        }
        for (int i = 3; i <= terms; i++)
        {
            next = first + sec;
            Console.Write(next);
            if (i < terms) Console.Write(", ");
            first = sec;
            sec = next;
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("Enter the number of terms for the Fibonacci sequence: ");
        int TermCnt = int.Parse(Console.ReadLine());
        Generate_Fibo(TermCnt);
    }
}
