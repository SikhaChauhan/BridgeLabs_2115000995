using System;

class Chocolates
{
    static void Main(string[] args)
    {
        Console.Write("Enter the total number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;
        Console.WriteLine($"The number of chocolates each child gets is {chocolatesPerChild} and the number of remaining chocolates is {remainingChocolates}");
    }
}
