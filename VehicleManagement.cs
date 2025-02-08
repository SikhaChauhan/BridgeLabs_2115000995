using System;
namespace VehicleManagement
{
    class Vehicle
    {
        public string Model;
        public int MaxSpeed;

        public Vehicle(string model, int maxSpeed)
        {
            Model = model;
            MaxSpeed = maxSpeed;
        }

        // Method to display vehicle information
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Max Speed: {MaxSpeed} km/h");
        }
    }

    public interface Refuelable
    {
        void Refuel();
    }

    class ElectricVehicle : Vehicle
    {
        public int BatteryCapacity;

        public ElectricVehicle(string model, int maxSpeed, int batteryCapacity)
            : base(model, maxSpeed)
        {
            BatteryCapacity = batteryCapacity;
        }

        // Override DisplayInfo to include BatteryCapacity
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Battery Capacity: {BatteryCapacity} kWh");
        }

        // Method to charge the electric vehicle
        public void Charge()
        {
            Console.WriteLine($"{Model} is charging...");
        }
    }

    class PetrolVehicle : Vehicle, Refuelable
    {
        public int FuelTankCapacity;

        public PetrolVehicle(string model, int maxSpeed, int fuelTankCapacity)
            : base(model, maxSpeed)
        {
            FuelTankCapacity = fuelTankCapacity;
        }

        // Override DisplayInfo to include FuelTankCapacity
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Fuel Tank Capacity: {FuelTankCapacity} liters");
        }

        // Implementation of Refuel() method
        public void Refuel()
        {
            Console.WriteLine($"{Model} is refueling...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ElectricVehicle tesla = new ElectricVehicle("Verna", 200, 75);
            Console.WriteLine("Electric Vehicle Details:");
            tesla.DisplayInfo();
            tesla.Charge();
            Console.WriteLine();

            PetrolVehicle honda = new PetrolVehicle("i20 Asta", 180, 50);
            Console.WriteLine("Petrol Vehicle Details:");
            honda.DisplayInfo();
            honda.Refuel();
            Console.WriteLine();
        }
    }
}
