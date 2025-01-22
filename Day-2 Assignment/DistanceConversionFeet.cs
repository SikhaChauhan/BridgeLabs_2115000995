using System;
class DistanceConversionFeet {
    public static void Main(string[] args) {
        Console.Write("Enter the distance in feet: ");
        double distanceFeet = Convert.ToDouble(Console.ReadLine());
        double distanceYards = distanceFeet / 3;
        double distanceMiles = distanceYards / 1760;
        Console.WriteLine($"The distance in yards is {distanceYards} and in miles is {distanceMiles}");
    }
}

