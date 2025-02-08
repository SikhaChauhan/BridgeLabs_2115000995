using System;
namespace Vehicle
{
    class Vehicle
    {
        public int MaxSpeed;
        public string FuelType;

        public Vehicle(int maxSpeed, string fuelType)
        {
            MaxSpeed = maxSpeed;
            FuelType = fuelType;
        }

        // Method to display vehicle information
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}");
        }
    }

    class Car : Vehicle
    {
        public int SeatCapacity;

        public Car(int maxSpeed, string fuelType, int seatCapacity)
            : base(maxSpeed, fuelType)
        {
            SeatCapacity = seatCapacity;
        }

        // Override DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Seat Capacity: {SeatCapacity}");
        }
    }

    class Truck : Vehicle
    {
        public int PayloadCapacity;

        public Truck(int maxSpeed, string fuelType, int payloadCapacity)
            : base(maxSpeed, fuelType)
        {
            PayloadCapacity = payloadCapacity;
        }

        // Override DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Payload Capacity: {PayloadCapacity} kg");
        }
    }

    class Motorcycle : Vehicle
    {
        public bool HasSidecar;

        public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
            : base(maxSpeed, fuelType)
        {
            HasSidecar = hasSidecar;
        }

        // Override DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Sidecar: {(HasSidecar ? "Yes" : "No")}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car(180, "Petrol", 8);
            Vehicle truck = new Truck(120, "Diesel", 1000);
            Vehicle motorcycle = new Motorcycle(150, "Petrol", true);

            Vehicle[] vehicles = { car, truck, motorcycle };

            Console.WriteLine("Vehicle Information:");
            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
