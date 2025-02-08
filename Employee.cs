using System;
namespace Employee
{
    class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }

        public Employee(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        // Method to display employee details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}, Salary: {Salary:C}");
        }
    }
    class Manager : Employee
    {
        public int TeamSize { get; set; }

        public Manager(string name, int id, double salary, int teamSize)
            : base(name, id, salary)
        {
            TeamSize = teamSize;
        }

        // Override DisplayDetails method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Team Size: {TeamSize}");
        }
    }

    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(string name, int id, double salary, string programmingLanguage)
            : base(name, id, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
        }
    }

    class Intern : Employee
    {
        public string InternshipDuration { get; set; }

        public Intern(string name, int id, double salary, string internshipDuration)
            : base(name, id, salary)
        {
            InternshipDuration = internshipDuration;
        }

        // Override DisplayDetails method
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Internship Duration: {InternshipDuration}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee manager = new Manager("Atharv", 14, 780000, 10);
            Employee developer = new Developer("Reeva", 13, 4560000, "C#");
            Employee intern = new Intern("Krishav", 04, 890000, "6 months");

            Console.WriteLine("Manager Details:");
            manager.DisplayDetails();
            Console.WriteLine();

            Console.WriteLine("Developer Details:");
            developer.DisplayDetails();
            Console.WriteLine();

            Console.WriteLine("Intern Details:");
            intern.DisplayDetails();
        }
    }
}
