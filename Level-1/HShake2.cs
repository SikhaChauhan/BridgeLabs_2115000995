using System;
class HShake2
{
    // This Function calculates the maximum number of handshakes
    static int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents= Convert.ToInt32(Console.ReadLine());
        int maxH_shakes = CalculateHandshakes(numberOfStudents);
        Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {maxH_shakes}.");
    }
}
