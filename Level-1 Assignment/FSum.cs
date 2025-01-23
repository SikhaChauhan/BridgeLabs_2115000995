using System;
class FSum {
    static void Main(string[] args) {
        formula_Sum();
    }
	static void formula_Sum(){
		Console.Write("Enter a natural number: ");
        int num = int.Parse(Console.ReadLine());
        if (num > 0) {
            int sum = 0;
            int i = 1;
            while (i <= num) {
                sum += i;
                i++;
            }
            int f_Sum = num * (num + 1) / 2;
            Console.WriteLine($"Sum using loop: {sum}, Sum using formula: {f_Sum}");
        } else {
            Console.WriteLine("Invalid natural number");
        }
	}
}
