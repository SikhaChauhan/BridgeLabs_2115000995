using System;

class Sum_Natural {
    static void Main(string[] args) {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        
        if (n >= 0) {
            int sum = sum_of_N(n);  
            Console.WriteLine($"The sum of the first {n} natural numbers is {sum}");
        } else {
            Console.WriteLine($"The number {n} is not a natural number.");
        }
    }

    static int sum_of_N(int n) {
        return n * (n + 1) / 2;
    }
}
