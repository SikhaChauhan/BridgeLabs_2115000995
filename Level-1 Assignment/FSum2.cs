using System;
class FSum2 {
    static void Main(string[] args) {
        formula_Sum();
    }
	static void formula_Sum(){
		Console.Write("Enter a natural number: ");
        int num = int.Parse(Console.ReadLine());
        if (num > 0) {
            int sum = 0;
            for (int i = 1; i <= num; i++) {
                sum += i;
            }
            int f_Sum = num * (num + 1) / 2;
            Console.WriteLine($"Sum using loop: {sum}, Sum using formula: {f_Sum}");
        } else {
            Console.WriteLine("Invalid natural number");
        }
	}
}
