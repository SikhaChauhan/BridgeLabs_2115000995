using System;
{
    class Employee
    {
        private string name;
        private int id;
        private double salary;
		
        public Employee(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        // Method to display employee details
        public void Display()
        {
            Console.WriteLine("Employee Personal Details:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Salary: {salary:C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Samaira", 10, 890000);
            Employee emp2 = new Employee("Reeva", 11, 1500060);
			Employee emp3 = new Employee("Pooja", 12, 7600090);

            emp1.Display();
            Console.WriteLine();
            emp2.Display();
        }
    }
}
