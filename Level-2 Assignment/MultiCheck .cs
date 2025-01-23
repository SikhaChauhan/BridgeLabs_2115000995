using System;
class MultiCheck 
{
	static void multi_check(int num) {
		for(int i=1; i<=100; i++) {
			Console.WriteLine($"{num * i}");
		}
	}
	static void Main(string[] args) {
		Console.Write("Enter a number (1 - 100): ");
        int num = int.Parse(Console.ReadLine());
		multi_check(num);
	}
}