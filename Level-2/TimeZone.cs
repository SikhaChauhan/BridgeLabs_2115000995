using System;
class TimeZone
{
    static void Main(string[] args)
    {
        DateTimeOffset time = DateTimeOffset.UtcNow;
        Console.WriteLine("Current UTC Time: " + time.ToString("yyyy-MM-dd HH:mm:ss"));

        Compute(time, "GMT Standard Time", "GMT Time");
        Compute(time, "India Standard Time", "IST Time");
        Compute(time, "Pacific Standard Time", "PST Time");
    }

	//This method is used to display current time in different Time Zones
    static void Compute(DateTimeOffset time, string time_ZoneId, string l)
    {
        TimeZoneInfo time_Zone = TimeZoneInfo.FindSystemTimeZoneById(time_ZoneId);
        DateTimeOffset l_Time = TimeZoneInfo.ConvertTime(time, time_Zone);
        Console.WriteLine($"{l}: {l_Time:yyyy-MM-dd HH:mm:ss}");
    }
}
