using System;
class FeeDiscount {
    public static void Main(string[] args) {
        Console.Write("Enter the fee amount: ");
        double fee = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the discount percentage: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());
        double discountAmount = fee * discountPercent / 100;
        double discountedFee = fee - discountAmount;
        Console.WriteLine($"The discount amount is INR {discountAmount} and final discounted fee is INR {discountedFee}");
    }
}

