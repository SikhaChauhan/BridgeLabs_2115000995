using System;

class Ctr_For {
    static void Main(string[] args) {
        Console.Write("Enter countdown start: ");
        int ctr = int.Parse(Console.ReadLine());
        for (int i = ctr; i >= 1; i--) {
            Console.WriteLine(i);
        }
        Console.WriteLine("Rocket launched!");
    }
	static void ctr_For(){
	}
	
}
