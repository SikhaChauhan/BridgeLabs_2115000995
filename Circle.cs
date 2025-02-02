using System;
namespace CircleNamespace
{
    public class Circle
    {
        public double Radius;
        public Circle() : this(1.0) 
        {
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Method to calculate the area of the circle
        public double Calc_Area()
        {
            return Math.PI * Radius * Radius;
        }

        // Method to calculate the circumference of the circle
        public double Calc_Circum()
        {
            return 2 * Math.PI * Radius;
        }

        public void Display()
        {
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {Calc_Area():F2}");
            Console.WriteLine($"Circumference: {Calc_Circum():F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle();
            Console.WriteLine("Default Constructor Circle:");
            circle1.Display();

            Console.WriteLine();
			
            Circle circle2 = new Circle(10.0);
            Console.WriteLine("Parameterized Constructor Circle:");
            circle2.Display();
        }
    }
}
