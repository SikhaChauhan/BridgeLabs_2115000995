using System;
class DiscountCalculation {
    public static void Main(string[] args) {
        double fee = 125000;
        double discountPercent = 10;
        double discountAmount = fee * discountPercent / 100;
        double discountedFee = fee - discountAmount;
        Console.WriteLine($"The discount amount is INR {discountAmount} and final discounted fee is INR {discountedFee}");
    }
}

