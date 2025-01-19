//Q5.Write a program to calculate the volume of a cylinder. Take the radius and height as inputs and use the formula


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the radius of the cylinder: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the cylinder: ");
        double height = Convert.ToDouble(Console.ReadLine());

        double volume = Math.PI * radius * radius * height;

        Console.WriteLine($"The volume of the cylinder is {volume}");
    }
}
