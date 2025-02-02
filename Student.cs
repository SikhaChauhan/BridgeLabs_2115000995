using System;
public class Student {
    public int rollNumber;
    protected string name;
    private double CGPA;

    public Student(int rollNumber, string name, double CGPA) {
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = CGPA;
    }

    public void ModifyCGPA(double newCGPA) {
        this.CGPA = newCGPA;
    }

    public void DisplayDetails() {
        Console.WriteLine("Student Roll Number:  " + rollNumber);
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Student CGPA: " + CGPA);
    }
}

class PostgraduateStudent : Student {
    public PostgraduateStudent(int rollNumber, string name, double CGPA) : base(rollNumber, name, CGPA) {
    }

    public new void DisplayDetails() {
        Console.WriteLine("Postgraduate Student Details:");
        base.DisplayDetails();
    }
}

class Program {
    public static void Main(string[] args) {
        Student student = new Student(13, "Krishav", 9.0);
        student.DisplayDetails();
		Console.WriteLine();
		
        student.ModifyCGPA(9.5);
		Console.WriteLine("Updated Student Details:");
		student.DisplayDetails();
		Console.WriteLine();
		
        PostgraduateStudent postgraduateStudent = new PostgraduateStudent(14, "Atharv", 8.9);
        postgraduateStudent.DisplayDetails();
		Console.WriteLine();
		
		postgraduateStudent.ModifyCGPA(9.8);
		Console.WriteLine("Updated Student Details:");
		postgraduateStudent.DisplayDetails();
    }
}
