using System;
namespace SmartHome
{
    class Device
    {
        public string DeviceId;
        public string Status;

        public Device(string deviceId, string status)
        {
            DeviceId = deviceId;
            Status = status;
        }

        // Method to display device status
        public virtual void DisplayStatus()
        {
            Console.WriteLine($"Device ID: {DeviceId}");
            Console.WriteLine($"Status: {Status}");
        }
    }

    public class Thermostat : Device
    {
        public int TemperatureSetting;

        public Thermostat(string deviceId, string status, int temperatureSetting)
            : base(deviceId, status)
        {
            TemperatureSetting = temperatureSetting;
        }

        // Override DisplayStatus method
        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine($"Temperature Setting: {TemperatureSetting}°C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Thermostat thermostat = new Thermostat("TH-001", "Online", 29);
			
            Console.WriteLine("Smart Home Device Status:");
            thermostat.DisplayStatus();
        }
    }
}
