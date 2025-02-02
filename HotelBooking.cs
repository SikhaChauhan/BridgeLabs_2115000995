using System;
namespace HotelBookingSystem
{
    public class HotelBooking
    {
        public string GuestName;
        public string RoomType;
        public int Nights;

        public HotelBooking()
        {
            GuestName = "Unknown Guest";
            RoomType = "Standard";
            Nights = 1;
        }

        public HotelBooking(string guestName, string roomType, int nights)
        {
            GuestName = guestName;
            RoomType = roomType;
            Nights = nights;
        }

        public HotelBooking(HotelBooking booking)
        {
            GuestName = booking.GuestName;
            RoomType = booking.RoomType;
            Nights = booking.Nights;
        }

        public void Display()
        {
            Console.WriteLine($"Guest Name: {GuestName}");
            Console.WriteLine($"Room Type: {RoomType}");
            Console.WriteLine($"Number of Nights: {Nights}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HotelBooking booking1 = new HotelBooking();
            Console.WriteLine("Default Booking:");
            booking1.Display();

            Console.WriteLine();

            HotelBooking booking2 = new HotelBooking("Krishu", "Deluxe", 8);
            Console.WriteLine("Parameterized Booking:");
            booking2.Display();

            Console.WriteLine();

            HotelBooking booking3 = new HotelBooking(booking2);
            Console.WriteLine("Copied Booking:");
            booking3.Display();

            Console.WriteLine();

            booking3.GuestName = "Mahi";
            booking3.RoomType = "Suite";
            booking3.Nights = 10;
            Console.WriteLine("Modified Copied Booking:");
            booking3.Display();

            Console.WriteLine();

            Console.WriteLine("Original Parameterized Booking (Unchanged):");
            booking2.Display();
        }
    }
}
