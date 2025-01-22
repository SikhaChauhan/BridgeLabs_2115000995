using System;

class Trip
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the starting city: ");
        string fromCity = Console.ReadLine();
        Console.Write("Enter the via city: ");
        string viaCity = Console.ReadLine();
        Console.Write("Enter the destination city: ");
        string toCity = Console.ReadLine();
        Console.Write("Enter the distance from starting city to via city (in miles): ");
        double fromToVia = double.Parse(Console.ReadLine());
        Console.Write("Enter the distance from via city to final city (in miles): ");
        double viaToFinalCity = double.Parse(Console.ReadLine());
        Console.Write("Enter the time taken for the journey (in hours): ");
        double timeTaken = double.Parse(Console.ReadLine());
        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;
        Console.WriteLine($"The results of the trip are: {totalDistance} miles, {timeTaken} hours, {averageSpeed} mph");
    }
}
