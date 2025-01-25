using System;
class Marks
{
    static void Main(string[] args)
    {
        CalcStudentGrds();
    }
// This Function computes the marks, percentage, and grades
    static void CalcStudentGrds()
    {
        int Students;
        Console.Write("Enter the number of students: ");
        while (!int.TryParse(Console.ReadLine(), out numStudents) || numStudents <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number.");
            Console.Write("Enter the number of students: ");
        }
        int[,] marks = new int[Students, 3];
        double[] percen = new double[Students];
        string[] grds = new string[Students];
        for (int i = 0; i < Students; i++)
        {
            Console.WriteLine($"Enter marks for Student {i + 1}:");
            marks[i, 0] = GetValMarks("Physics");
            marks[i, 1] = GetValMarks("Chemistry");
            marks[i, 2] = GetValMarks("Maths");
            int ttlMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percen[i] = (ttlMarks / 3.0);
            if (percen[i] >= 90)
            {
                grds[i] = "A";
            }
            else if (percen[i] >= 80)
            {
                grds[i] = "B";
            }
            else if (percen[i] >= 70)
            {
                grds[i] = "C";
            }
            else if (percen[i] >= 60)
            {
                grds[i] = "D";
            }
            else
            {
                grds[i] = "F";
            }
        }
        Console.WriteLine("Student Results:");
        for (int i = 0; i < \Students; i++)
        {
            Console.WriteLine($"Student {i + 1} Physics marks {marks[i, 0]}, Chemistry marks {marks[i, 1]}, Maths marks{marks[i, 2]}, Percentage is {percen[i]:0.00} and grades are {grds[i]}");
        }
    }
    static int GetValMarks(string subj)
    {
        int marks;
        while (true)
        {
            Console.Write($"Enter marks for {subject} (0-100): ");
            if (int.TryParse(Console.ReadLine(), out marks) && marks >= 0 && marks <= 100)
            {
                return marks;
            }
            else
            {
                Console.WriteLine("Invalid marks. Please enter a value between 0 and 100.");
            }
        }
    }
}
