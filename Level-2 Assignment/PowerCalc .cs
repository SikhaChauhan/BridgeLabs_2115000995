using System;
class PowerCalc 
{
	static void Main(string[] args) {
		Console.Write("Enter the base: ");
        int basee = int.Parse(Console.ReadLine());
		Console.Write("Enter the power: ");
        int pow = int.Parse(Console.ReadLine());
		power_Calc(basee, pow);
	}
	static void power_Calc(int pow, int basee) {
		int exponen = 1;
		for(int i=1; i<=pow; i++ ) {
			exponen *= basee;
		}
		Console.WriteLine($"The Exponent of {basee} power {pow} is: {exponen}");
	}
}