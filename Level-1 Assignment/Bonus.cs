using System;

class Bonus {
    static void Main(string[] args) {
        bonus_Sal();
    }
	static void bonus_Sal(){
		Console.Write("Enter salary: ");
        double sal = double.Parse(Console.ReadLine());
        Console.Write("Enter years of service: ");
        int yrs = int.Parse(Console.ReadLine());
        if (yrs > 5) {
            double bonus = sal * 0.05;
			r_bonus = Math.Round(bonus, 2);
            Console.WriteLine($"Bonus amount is {bonus:F2}");
        } else {
            Console.WriteLine("No bonus");
        }
	}
}
