using System;
using System.Collections.Generic;

class Faculty
{
    public string Name { get; }
    public string Specialization { get; }

    public Faculty(string name, string specialization)
    {
        Name = name;
        Specialization = specialization;
    }

    public void DisplayFaculty()
    {
        Console.WriteLine($" - Faculty: {Name}, Specialization: {Specialization}");
    }
}

class Department
{
    public string Name { get; }

    public Department(string name)
    {
        Name = name;
    }

    public void DisplayDepartment()
    {
        Console.WriteLine($"Department: {Name}");
    }
}

class University
{
    public string Name { get; }
    private List<Department> departments;
    private List<Faculty> faculties;

    public University(string name)
    {
        Name = name;
        departments = new List<Department>();
        faculties = new List<Faculty>();
    }

    public void AddDepartment(string departmentName)
    {
        departments.Add(new Department(departmentName));
    }

    public void AddFaculty(Faculty faculty)
    {
        if (!faculties.Contains(faculty))
        {
            faculties.Add(faculty);
        }
    }

    public void DisplayUniversity()
    {
        Console.WriteLine($"\nUniversity: {Name}");

        Console.WriteLine("\nDepartment Names:");
        if (departments.Count == 0)
            Console.WriteLine(" No departments available.");
        foreach (var dept in departments)
            dept.DisplayDepartment();

        Console.WriteLine("\nFaculty Members:");
        if (faculties.Count == 0)
            Console.WriteLine(" No faculty members.");
        foreach (var faculty in faculties)
            faculty.DisplayFaculty();
    }

    ~University()
    {
        Console.WriteLine($"\nUniversity '{Name}' is being deleted, removing all its departments.");
    }
}

class Program
{
    static void Main()
    {
        University myUniversity = new University("GLA University");

        myUniversity.AddDepartment("Computer Science");
        myUniversity.AddDepartment("BA");

        Faculty professor1 = new Faculty("Dr. Krishav", "Java");
        Faculty professor2 = new Faculty("Dr. Atharv", "English");

        myUniversity.AddFaculty(professor1);
        myUniversity.AddFaculty(professor2);

        myUniversity.DisplayUniversity();

        myUniversity = null;
        GC.Collect();

        Console.WriteLine("\nIndependent Faculty Members (After University Deletion):");
        professor1.DisplayFaculty();
        professor2.DisplayFaculty();
    }
}
