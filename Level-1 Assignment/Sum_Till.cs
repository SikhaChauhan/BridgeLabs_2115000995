using System;

class SumTill{
    static void Main(string[] args) {
        sum_till();
    }
	static void sum_till(){
		double ttl = 0.0;
		double num;
        while (true) {
            Console.Write("Enter a number (0 to stop): ");
            num = double.Parse(Console.ReadLine());
            if (num == 0) break;
            ttl += num;
        }
        Console.WriteLine($"The total sum is {ttl}");
	}
}
