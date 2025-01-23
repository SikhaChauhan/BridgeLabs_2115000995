using System;

class Fact {
    static void Main(string[] args) {
        facto();
    }
	static void facto(){
		Console.Write("Enter a positive integer: ");
        int num = int.Parse(Console.ReadLine());
        if (num >= 0) {
            int fact = 1, i = 1;
            while (i <= num) {
                fact *= i;
                i++;
            }
            Console.WriteLine($"Factorial of {num} is {fact}");
        } else {
            Console.WriteLine("Invalid input");
        }
	}
}
