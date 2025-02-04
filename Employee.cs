using System;
class Employee
{

    private static string companyName = "Apple";
    private static int totalEmployees = 0;

    public readonly int Id;
    public string Name;
    public string Designation;

    public static string CompanyName
    {
        get { return companyName; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                companyName = value;
                Console.WriteLine($"Company name updated to: {companyName}");
            }
            else
            {
                Console.WriteLine("Company name cannot be empty.");
            }
        }
    }

    public Employee(string Name, int Id, string Designation)
    {
        this.Name = Name;
        this.Id = Id;
        this.Designation = Designation;
        totalEmployees++;
    }

    // Static method to display total number of employees
    public static void DisplayTotalEmployees()
    {
        Console.WriteLine($"Total Employees: {totalEmployees}");
    }

    // Method to display employee details using 'is' operator
    public void DisplayEmployeeDetails()
    {
        if (this is Employee)
        {
            Console.WriteLine($"Company: {companyName}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Employee ID: {Id}");
            Console.WriteLine($"Designation: {Designation}");
        }
    }
}

class Program
{
    static void Main()
    {

        Employee emp1 = new Employee("Krishav", 13, "AI Developer");
        Employee emp2 = new Employee("Atharv", 14, "Software Developer");
		Employee emp3 = new Employee("Reeva", 04, "Graphic Designer");

        Console.WriteLine("Before Changing Company Name:");
        emp1.DisplayEmployeeDetails();
        Console.WriteLine();
        emp2.DisplayEmployeeDetails();

        Console.WriteLine("Changing Company Name...\n");

        Employee.CompanyName = "Amazon";

        Console.WriteLine("After Changing Company Name:");
        emp1.DisplayEmployeeDetails();
        Console.WriteLine();
        emp2.DisplayEmployeeDetails();

        Console.WriteLine();

        Employee.DisplayTotalEmployees();
    }
}
