using System;

class Check_Num {
    static void Main(string[] args) {
        check_Num();
    }
	static void check_Num(){
		Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        if (num > 0) {
            Console.WriteLine("Positive");
        } else if (num < 0) {
            Console.WriteLine("Negative");
        } else {
            Console.WriteLine("Zero");
        }
	}
}
