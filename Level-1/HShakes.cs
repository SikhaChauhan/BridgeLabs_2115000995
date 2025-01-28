using System;
class HShakes
{
    // This function calculates the maximum number of handshakes
    static int Calc_Hshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter the number of students: ");
        int stud = Convert.ToInt32(Console.ReadLine());
        if (stud <= 1)
        {
            Console.WriteLine("The number of students must be greater than 1 to have handshakes.");
        }
        else
        {
            int maxH_shakes = Calc_Hshakes(stud);
            Console.WriteLine($"The maximum number of handshakes among {stud} students is {maxH_shakes}.");
        }
    }
}
