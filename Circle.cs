using System;
{
    class Circle
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Method to calculate the area of the circle
        public double Calc_Area()
        {
            return Math.PI * radius * radius;
        }

        // Method to calculate the circumference of the circle
        public double Calc_Circum()
        {
            return 2 * Math.PI * radius;
        }

        // Method to display the area and circumference
        public void Display()
        {
            Console.WriteLine("Circle Details:");
            Console.WriteLine($"Radius: {radius}");
            Console.WriteLine($"Area: {Calc_Area():F2}");
            Console.WriteLine($"Circumference: {Calc_Circum():F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(radius);
            circle.Display();
        }
    }
}
