using System;
namespace Restaurant
{
    class Person
    {
        public string Name;
        public int Id;

        public Person(string name, int id)
        {
            Name = name;
            Id = id;
        }

        // Method to display basic details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {Id}");
        }
    }

    public interface Worker
    {
        void PerformDuties();
    }

    class Chef : Person, Worker
    {
        public string Specialty;

        public Chef(string name, int id, string specialty) : base(name, id)
        {
            Specialty = specialty;
        }

        // Override DisplayDetails to include specialty
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Specialty: {Specialty}");
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{Name} is cooking delicious {Specialty} dishes.");
        }
    }

    class Waiter : Person, Worker
    {
        public string Section;

        public Waiter(string name, int id, string section) : base(name, id)
        {
            Section = section;
        }

        // Override DisplayDetails to include section
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Section: {Section}");
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{Name} is serving customers in the {Section} section.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef("Atharv", 14, "Indian Dessert");
            Console.WriteLine("Chef Details:");
            chef.DisplayDetails();
            chef.PerformDuties();
            Console.WriteLine();

            Waiter waiter = new Waiter("Krishav", 13, "Outdoor");
            Console.WriteLine("Waiter Details:");
            waiter.DisplayDetails();
            waiter.PerformDuties();
            Console.WriteLine();
        }
    }
}
