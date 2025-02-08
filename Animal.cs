using System;

namespace Animal
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to make a generic sound
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        // Override MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine("Bird chirps.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Trippy", 10);
            Animal cat = new Cat("Sonu", 8);
            Animal bird = new Bird("Chuja", 3);

            dog.MakeSound();  
            cat.MakeSound();  
            bird.MakeSound(); 

            Console.WriteLine($"{dog.Name}, Age: {dog.Age}");
            Console.WriteLine($"{cat.Name}, Age: {cat.Age}");
            Console.WriteLine($"{bird.Name}, Age: {bird.Age}");
        }
    }
}
