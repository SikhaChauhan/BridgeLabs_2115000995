using System;
class Fact2 {
    static void Main(string[] args) {
        facto();
    }
	static void facto(){
		Console.Write("Enter a positive integer: ");
        int num = int.Parse(Console.ReadLine());
        if (num >= 0) {
            int fact = 1;
            for (int i = 1; i <= num; i++) {
                fact *= i;
            }
            Console.WriteLine($"Factorial of {num} is {fact}");
        } else {
            Console.WriteLine("Invalid input");
        }
	}
}
