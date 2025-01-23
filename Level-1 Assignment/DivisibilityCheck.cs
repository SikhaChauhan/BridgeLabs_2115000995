using System;

class DivisibilityCheck {
    static void Main(string[] args) {
		Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Is the number {num} divisible by 5? {Divisible(num)}");
    }
	static bool Divisible(int num){
		if(num % 5 == 0){
			return true;
		}
		else{
			return false;
		}
	}
}
