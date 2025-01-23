using System;

class Check_Spring {
    static void Main(string[] args) {
        check_Spring();
    }
	static void check_Spring(){
		Console.Write("Enter month: ");
        int mon = int.Parse(Console.ReadLine());
        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());
        
        if ((mon == 3 && day >= 20) || (mon == 6 && day <= 20) || (mon > 3 && mon < 6)) {
            Console.WriteLine("It's a Spring Season");
        } else {
            Console.WriteLine("Not a Spring Season");
        }
	}
}
