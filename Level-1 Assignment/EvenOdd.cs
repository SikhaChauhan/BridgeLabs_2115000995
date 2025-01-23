using System;
class EvenOdd {
    static void Main(string[] args) {
        even_Odd();
    }
	static void even_Odd(){
		Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        if (num >= 1) {
            for (int i = 1; i <= num; i++) {
                Console.WriteLine($"{i} is {(i % 2 == 0 ? "Even" : "Odd")}");
            }
        } 
		else {
            Console.WriteLine("Invalid input");
        }
	}
}
