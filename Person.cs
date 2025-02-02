using System;
namespace PersonNamespace
{
    public class Person
    {
        public string Name;
        public int Age;

        public Person()
        {
            Name = "Unknown";
            Age = 0;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(Person person0)
        {
            Name = person0.Name;
            Age = person0.Age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Mahi", 43);
            Console.WriteLine("Original Person:");
            person1.Display();

            Console.WriteLine();

            Person person2 = new Person(person1);
            Console.WriteLine("Cloned Person:");
            person2.Display();

            Console.WriteLine();

            person2.Name = "Reeva";
            person2.Age = 1;
            Console.WriteLine("Modified Cloned Person:");
            person2.Display();

            Console.WriteLine();

            Console.WriteLine("Original Person (Unchanged):");
            person1.Display();
        }
    }
}
