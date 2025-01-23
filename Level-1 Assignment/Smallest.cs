using System;

class Smallest {
    static void Main(string[] args) {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Is the first number the smallest? {Smallest(num1, num2, num3)}");
    }
	static bool Smallest(int num1, int num2, int num3){
		if(num1 < num2 && num1 < num3){
			return true;
		}
		else{
			return false;
		}
	}
}

