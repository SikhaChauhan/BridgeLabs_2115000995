using System;
class UserDistanceConversion {
    public static void Main(string[] args) {
        Console.Write("Enter the distance in kilometers: ");
        double kilometers = Convert.ToDouble(Console.ReadLine());
        double miles = kilometers / 1.6;
        Console.WriteLine($"The total miles is {miles} miles for the given {kilometers} km");
    }
}

