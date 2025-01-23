using System;
class SumTill2 {
    static void Main(string[] args) {
        sum_till_2();
    }
	static void sum_till_2(){
		double ttl = 0.0;
		double num;
        while (true) {
            Console.Write("Enter a number (negative or 0 to stop): ");
            num = double.Parse(Console.ReadLine());
            if (num <= 0) break;
            ttl += num;
        }
        Console.WriteLine($"The total sum is {ttl}");
	}
}
