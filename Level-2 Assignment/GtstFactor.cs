using System;
class GtstFactor 
{
	static void Main(string[] args) {
		Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
		
		G_factor(num);
	}
	static void G_factor(int num) {
		for(int i = num-1; i >= 1; i--) {
			if(num % i == 0) {
				Console.Write($"The greatest factor of {num} is: {i}");
				return;
			}
		}
	}
}