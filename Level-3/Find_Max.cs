using System;
class Find_Max
{
    // Function to take an integer input from the user
    static int Take_Input(string str)
    {
        Console.WriteLine(str);
        int input = int.Parse(Console.ReadLine());
        return input;
    }
    // Function to find the maximum of three numbers
    static int Max_Element(int num1, int num2, int num3)
    {
        if (num1 >= num2 && num1 >= num3)
        {
            return num1; 
        }
        else if (num2 >= num1 && num2 >= num3)
        {
            return num2;
        }
        else
        {
            return num3; 
        }
    }
    static void Main()
    {
        int num1 = Take_Input("Enter the first number: ");
        int num2 = Take_Input("Enter the second number: ");
        int num3 = Take_Input("Enter the third number: ");
        int max = Max_Element(num1, num2, num3);
        Console.WriteLine($"The maximum of {num1}, {num2}, and {num3} is: {max}");
    }
}
