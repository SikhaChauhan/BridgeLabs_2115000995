using System;
class TriangleArea {
    public static void Main(string[] args) {
        Console.Write("Enter the base of the triangle in cm: ");
        double baseCm = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the height of the triangle in cm: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());
        double areaCm = 0.5 * baseCm * heightCm;
        Console.WriteLine($"The area of the triangle is {areaCm} square centimeters");
    }
}

