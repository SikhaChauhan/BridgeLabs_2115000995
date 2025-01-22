using System;

class TriangularPark
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first side of the triangular park (in meters): ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second side of the triangular park (in meters): ");
        double side2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the third side of the triangular park (in meters): ");
        double side3 = double.Parse(Console.ReadLine());
        double perimeter = side1 + side2 + side3;
        double rounds = 5000 / perimeter;
        Console.WriteLine($"The total number of rounds the athlete will run is {rounds:F2} to complete 5 km");
    }
}
