class DoubleOpt
{
    static void Main(string[] args)
    {
        Console.Write("Enter the value of a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the value of b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the value of c: ");
        double c = double.Parse(Console.ReadLine());
        double result1 = a + b * c;
        double result2 = a * b + c;
        double result3 = c + a / b;
        double result4 = a % b + c;
        Console.WriteLine($"The results of Double Operations are {result1}, {result2}, {result3}, and {result4}");
    }
}
