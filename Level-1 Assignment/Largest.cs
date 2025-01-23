using System;

class Largest {
    static void Main() {
        Console.Write("Enter 1st no.: ");
        int n_1 = int.Parse(Console.ReadLine());
        Console.Write("Enter 2nd no.: ");
        int n_2 = int.Parse(Console.ReadLine());
        Console.Write("Enter 3rd no.: ");
        int n_3 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Is the 1st no. the largest? {n_1 > n_2 && n_1 > n_3}");
        Console.WriteLine($"Is the 2nd no. the largest? {n_2 > n_1 && n_2 > n_3}");
        Console.WriteLine($"Is the 3rd no. the largest? {n_3 > n_1 && n_3 > n_2}");
    }
}
