using System;
class FizziBuzzi2
{
    static void Main(string[] args)
    {
        fizzibuzzi();
    }
	static void fizzibuzzi(){
		Console.Write("Enter a positive integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("Please enter a positive integer!");
                return;
            }
            while(num != 0)
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(num);
                }
				num--;
            }
	}
}
