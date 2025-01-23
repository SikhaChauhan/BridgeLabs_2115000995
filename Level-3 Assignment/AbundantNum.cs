using System;
class AbundantNum
{
    static void Main(string[] args)
    {
        checkNum();
    }
    static void checkNum(){
	Console.Write("Enter a number: ");
        int num_Check = int.Parse(Console.ReadLine());
        int divisor_Sum = 0;
        for (int i = 1; i < num_Check; i++)
        {
            if (num_Check % i == 0)
                divisor_Sum += i;
        }
        if (divisor_Sum > num_Check){
            Console.WriteLine($"{num_Check} is an Abundant Number.");
	}
        else{
            Console.WriteLine($"{num_Check} is not an Abundant Number.");
	}
     }
}
