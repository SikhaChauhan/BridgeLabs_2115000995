using System;

class ArmstgNum
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int ip_Num = int.Parse(Console.ReadLine());
        int sum_Cubes = 0, temp = ip_Num;

        while (temp != 0)
        {
            int remdr = temp % 10;
            sum_Cubes += remdr * remdr * remdr;
            temp /= 10;
        }

        if (sum_Cubes == ip_Num){
            Console.WriteLine($"{ip_Num} is an Armstrong Number.");
        }
        else{
            Console.WriteLine($"{ip_Num} is not an Armstrong Number.");
        }
    }
}
