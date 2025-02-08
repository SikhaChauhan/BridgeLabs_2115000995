using System;
namespace SchoolSystem
{
    class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Virtual method to display role
        public virtual void DisplayRole()
        {
            Console.WriteLine("I am a person.");
        }

        // Method to display common details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }

    class Teacher : Person
    {
        public string Subject;

        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        // Override DisplayRole method
        public override void DisplayRole()
        {
            Console.WriteLine("I am a Teacher.");
        }

        // Override DisplayDetails method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Subject: {Subject}");
        }
    }

    class Student : Person
    {
        public string Grade { get; set; }

        public Student(string name, int age, string grade) : base(name, age)
        {
            Grade = grade;
        }

        // Override DisplayRole method
        public override void DisplayRole()
        {
            Console.WriteLine("I am a Student.");
        }

        // Override DisplayDetails method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Grade: {Grade}");
        }
    }

    class Staff : Person
    {
        public string Department { get; set; }

        public Staff(string name, int age, string department) : base(name, age)
        {
            Department = department;
        }

        // Override DisplayRole method
        public override void DisplayRole()
        {
            Console.WriteLine("I am a Staff member.");
        }

        // Override DisplayDetails method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Department: {Department}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Atharv", 35, "Mathematics");
            Console.WriteLine("Teacher Details:");
            teacher.DisplayRole();
            teacher.DisplayDetails();
            Console.WriteLine();

            Student student = new Student("Krishav", 15, "10th Grade");
            Console.WriteLine("Student Details:");
            student.DisplayRole();
            student.DisplayDetails();
            Console.WriteLine();

            Staff staff = new Staff("Reeva", 40, "Administration");
            Console.WriteLine("Staff Details:");
            staff.DisplayRole();
            staff.DisplayDetails();
        }
    }
}
