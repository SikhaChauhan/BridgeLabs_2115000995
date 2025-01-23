using System;

class Ctr_Start {
    static void Main(string[] args) {
        ctr_Start();
    }
	static void ctr_Start(){
		Console.Write("Enter countdown start: ");
        int ctr = int.Parse(Console.ReadLine());
        while (ctr >= 1) {
            Console.WriteLine(ctr);
            ctr--;
        }
        Console.WriteLine("Rocket launched!");
	}
}
