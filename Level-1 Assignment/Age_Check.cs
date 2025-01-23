using System;

class Age_Check {
    static void Main(string[] args) {
        age_Check();
    }

    static void age_Check() {
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());
        if (age >= 18) {
            Console.WriteLine($"The person's age is {age} and can vote.");
        } else {
            Console.WriteLine($"The person's age is {age} and cannot vote.");
        }
    }
}
