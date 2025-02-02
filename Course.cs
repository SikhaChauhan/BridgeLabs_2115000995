using System;

namespace OnlineCourseManagement
{
    public class Course
    {
        public string CourseName;
        public int Duration;
        public decimal Fee;

        public static string InstituteName = "GLA University";

        public Course(string courseName, int duration, decimal fee)
        {
            CourseName = courseName;
            Duration = duration;
            Fee = fee;
        }

        // Instance Method to Display Course Details
        public void DisplayCourseDetails()
        {
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Duration: {Duration} weeks");
            Console.WriteLine($"Fee: Rs.{Fee}");
            Console.WriteLine($"Institute Name: {InstituteName}");
        }

        // Class Method to Update Institute Name
        public static void UpdateInstituteName(string newInstituteName)
        {
            InstituteName = newInstituteName;
            Console.WriteLine($"Institute Name updated to: {InstituteName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating course instances
            Course course1 = new Course("AI/ML", 12, 190500.00m);
            Course course2 = new Course("Cyber Security", 8, 172000.00m);

            // Displaying initial course details
            Console.WriteLine("Course 1 Details:");
            course1.DisplayCourseDetails();

            Console.WriteLine("\nCourse 2 Details:");
            course2.DisplayCourseDetails();

            // Updating the institute name using the class method
            Console.WriteLine("\nUpdating Institute Name...");
            Course.UpdateInstituteName("Ganeshari Lal Agrawal University");

            // Displaying course details again to reflect updated institute name
            Console.WriteLine("\nUpdated Course 1 Details:");
            course1.DisplayCourseDetails();

            Console.WriteLine("\nUpdated Course 2 Details:");
            course2.DisplayCourseDetails();
        }
    }
}
