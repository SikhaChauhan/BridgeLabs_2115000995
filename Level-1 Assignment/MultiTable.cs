using System;
class MultiTable {
    static void Main(string[] args) {
        multi();
    }
	static void multi(){
		Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 6; i <= 9; i++) {
            Console.WriteLine($"{num} * {i} = {num * i}");
        }
	}
}
