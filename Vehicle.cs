using System;

namespace VehicleRegistration
{
    public class Vehicle
    {
        public string OwnerName; 
        public string VehicleType;

        public static decimal RegistrationFee = 1000.00m; 

        public Vehicle(string ownerName, string vehicleType)
        {
            OwnerName = ownerName;
            VehicleType = vehicleType;
        }

        // Instance Method to Display Vehicle Details
        public void DisplayVehicleDetails()
        {
            Console.WriteLine($"Owner Name: {OwnerName}");
            Console.WriteLine($"Vehicle Type: {VehicleType}"); // Corrected this reference
            Console.WriteLine($"Registration Fee: Rs.{RegistrationFee}");
        }

        // Class Method to Update Registration Fee
        public static void UpdateRegistrationFee(decimal newFee)
        {
            RegistrationFee = newFee;
            Console.WriteLine($"Registration Fee updated to: Rs.{RegistrationFee}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle("Krishav", "Car");
            Vehicle vehicle2 = new Vehicle("Atharv", "Car");
            Vehicle vehicle3 = new Vehicle("Reeva", "Car");

            Console.WriteLine("Vehicle 1 Details:");
            vehicle1.DisplayVehicleDetails();

            Console.WriteLine("\nVehicle 2 Details:");
            vehicle2.DisplayVehicleDetails();
			
			Console.WriteLine("\nVehicle 3 Details:");
            vehicle3.DisplayVehicleDetails();

            Console.WriteLine("\nUpdating Registration Fee...");
            Vehicle.UpdateRegistrationFee(15000.00m);
			
            Console.WriteLine("\nUpdated Vehicle 1 Details:");
            vehicle1.DisplayVehicleDetails();

            Console.WriteLine("\nUpdated Vehicle 2 Details:");
            vehicle2.DisplayVehicleDetails();
			
			Console.WriteLine("\nUpdated Vehicle 3 Details:");
            vehicle3.DisplayVehicleDetails();
        }
    }
}
