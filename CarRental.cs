using System;
namespace CarRentalSystem
{
    public class CarRental
    {
        public string CustomerName;
        public string CarModel;
        public int RentalDays;
        public decimal DailyPrice;

        public CarRental()
        {
            CustomerName = "Unknown Customer";
            CarModel = "Unknown Model";
            RentalDays = 0;
            DailyPrice = 50.0m;
        }

        public CarRental(string customerName, string carModel, int rentalDays, decimal dailyPrice = 50.0m)
        {
            CustomerName = customerName;
            CarModel = carModel;
            RentalDays = rentalDays;
            DailyPrice = dailyPrice;
        }

        public CarRental(CarRental rental0)
        {
            CustomerName = rental0.CustomerName;
            CarModel = rental0.CarModel;
            RentalDays = rental0.RentalDays;
            DailyPrice = rental0.DailyPrice;
        }

        public decimal Calc_Ttl_Cost()
        {
            return RentalDays * DailyPrice;
        }

        public void Display()
        {
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Car Model: {CarModel}");
            Console.WriteLine($"Rental Days: {RentalDays}");
            Console.WriteLine($"Daily Price: Rs{DailyPrice}");
            Console.WriteLine($"Total Cost: Rs{Calc_Ttl_Cost()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CarRental rental1 = new CarRental();
            Console.WriteLine("Default Rental Details:");
            rental1.Display();

            Console.WriteLine();

            CarRental rental2 = new CarRental("Atharv", "Odi", 10, 90.0m);
            Console.WriteLine("Parameterized Rental Details:");
            rental2.Display();

            Console.WriteLine();

            CarRental rental3 = new CarRental(rental2);
            Console.WriteLine("Copied Rental Details:");
            rental3.Display();
        }
    }
}
