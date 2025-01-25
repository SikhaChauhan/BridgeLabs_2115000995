using System;
class Grades
{
    static void Main(string[] args)
    {
        CalculateGrades();
    }
// This Function computes the marks, percentage, and grades
    static void CalculateGrades()
    {
        int Students;
        Console.Write("Enter the number of students: ");
        while (!int.TryParse(Console.ReadLine(), out Students) || Students <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid number of students.");
            Console.Write("Enter the number of students: ");
        }
        double[,] marks = new double[Students, 3];  
        double[] percen = new double[Students]; 
        string[] grds = new string[Students];     
        for (int i = 0; i < Students; i++)
        {
            Console.WriteLine($"Enter marks for Student {i + 1}:");
            for (int j = 0; j < 3; j++)
            {
                while (true)
                {
                    Console.Write($"Enter marks for {(j == 0 ? "Physics" : j == 1 ? "Chemistry" : "Maths")}: ");
                    if (double.TryParse(Console.ReadLine(), out marks[i, j]) && marks[i, j] >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid marks. Please enter a positive number.");
                    }
                }
            }
            double ttlMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percen[i] = (ttlMarks / 300) * 100; 
            if (percen[i] >= 80)
            {
                grades[i] = "A";
            }
            else if (percen[i] >= 60)
            {
                grades[i] = "B";
            }
            else if (percen[i] >= 40)
            {
                grades[i] = "C";
            }
            else
            {
                grades[i] = "F";
            }
        }
        Console.WriteLine("Student Marks, Percentages, and Grades:");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"Student {i + 1,8} Physics marks {marks[i, 0],7}, Chemistry marks {marks[i, 1],9}, Maths marks {marks[i, 2],5}, Percentage is {percentages[i],10:0.00} and Grades are{grades[i],5}");
        }
    }
}
