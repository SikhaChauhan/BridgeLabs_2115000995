// using System;
// class Fact_Calc
// {
//     // Function to take input from the user
//     static int Enter_Input()
//     {
//         Console.Write("Enter a number: ");
//         return int.Parse(Console.ReadLine());
//     }
//     // Recursive function to calculate factorial
//     static int Calc_Fact(int num)
//     {
//         if (num == 0 || num == 1)
//         {
//             return 1;
//         }
//         else
//         {
//             return num * Calc_Fact(num - 1);
//         }
//     }
//     // Function to display the result
//     static void Display_Res(int num, int res)
//     {
//         Console.WriteLine($"The factorial of {num} is {res}");
//     }
//     static void Main()
//     {
//         int num = Enter_Input();
//         int res = Calc_Fact(num);
//         Display_Res(num, res);
//     }
// }
