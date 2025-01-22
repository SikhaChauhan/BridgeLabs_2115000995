using System;
class HeightConversion {
    public static void Main(string[] args) {
        Console.Write("Enter your height in centimeters: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());
        double heightInches = heightCm / 2.54;
        int heightFeet = (int)(heightInches / 12);
        heightInches %= 12;
        Console.WriteLine($"Your Height in cm is {heightCm} while in feet is {heightFeet} and inches is {heightInches}");
    }
}