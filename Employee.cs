using System;

public class Employee
{
    public int EmployeeID;
    protected string Department; 
    private decimal Salary; 

    public Employee(int employeeID, string department, decimal salary)
    {
        EmployeeID = employeeID;
        Department = department;
        Salary = salary;
    }

    // Method to set a new salary
    public void UpdateSalary(decimal newSalary)
    {
        if (newSalary > 0)
        {
            Salary = newSalary;
            Console.WriteLine($"Salary updated to: {Salary:C}");
        }
        else
        {
            Console.WriteLine("Salary must be greater than zero.");
        }
    }

    // Method to get the current salary
    public decimal GetSalary()
    {
        return Salary;
    }
}

// Subclass Manager 
public class Manager : Employee
{
    public int TeamSize;

    public Manager(int employeeID, string department, decimal salary, int teamSize)
        : base(employeeID, department, salary)
    {
        TeamSize = teamSize;
    }

    // Method to display manager details
    public void DisplayManagerDetails()
    {
        Console.WriteLine($"Employee ID: {EmployeeID}"); 
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Salary: Rs.{GetSalary():C}"); 
        Console.WriteLine($"Team Size: {TeamSize}");
    }
}

class Program
{
    public static void Main(string[] args)
    {

        Manager manager = new Manager(101, "Teaching", 750000.00m, 10);

        Console.WriteLine("Initial Manager Details:");
        manager.DisplayManagerDetails();

        Console.WriteLine("\nUpdating Salary...");
        manager.UpdateSalary(850000.00m);

        Console.WriteLine("\nUpdated Manager Details:");
        manager.DisplayManagerDetails();
    }
}
