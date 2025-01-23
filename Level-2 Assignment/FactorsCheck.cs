using System;
class FactorsCheck {
	static void Main(string[] args) {
		Console.Write("Enter a number (1 - 100): ");
        int num = int.Parse(Console.ReadLine());
		if(num > 100) {
			Console.WriteLine("Invalid Input");
		}
		factors_check(num);
	}
	static void factors_check(int num) {
		for(int i=1; i<= num; i++) {
			if(num % i == 0) {
				Console.WriteLine($"{i}");
			}
		}
	}
	
} 