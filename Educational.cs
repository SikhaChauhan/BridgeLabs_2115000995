using System;
namespace Educational
{
    class Course
    {
        public string CourseName;
        public int Duration;

        public Course(string courseName, int duration)
        {
            CourseName = courseName;
            Duration = duration;
        }

        // Method to display course details
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Duration: {Duration} hours");
        }
    }

    class OnlineCourse : Course
    {
        public string Platform;
        public bool IsRecorded;

        public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
            : base(courseName, duration)
        {
            Platform = platform;
            IsRecorded = isRecorded;
        }

        // Override DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Platform: {Platform}");
            Console.WriteLine($"Recorded: {(IsRecorded ? "Yes" : "No")}");
        }
    }

    class PaidOnlineCourse : OnlineCourse
    {
        public double Fee;
        public double Discount;

        public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
            : base(courseName, duration, platform, isRecorded)
        {
            Fee = fee;
            Discount = discount;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            double discountedFee = Fee - (Fee * Discount / 100);
            Console.WriteLine($"Fee: ${Fee}");
            Console.WriteLine($"Discount: {Discount}%");
            Console.WriteLine($"Fee after Discount: ${discountedFee}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course("Introduction to Programming", 20);
            Console.WriteLine("Course Details:");
            course.DisplayInfo();
            Console.WriteLine();

            OnlineCourse onlineCourse = new OnlineCourse("Web Development Basics", 30, "Dataflair", true);
            Console.WriteLine("Online Course Details:");
            onlineCourse.DisplayInfo();
            Console.WriteLine();

            PaidOnlineCourse paidOnlineCourse = new PaidOnlineCourse("Advanced Java", 40, "Udemy", true, 199.99, 20);
            Console.WriteLine("Paid Online Course Details:");
            paidOnlineCourse.DisplayInfo();
        }
    }
}
