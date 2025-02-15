using System;
class Matrix
{
    public static bool SearchMatrix(int[,] matrix, int target)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int left = 0, right = rows * cols - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int midValue = matrix[mid / cols, mid % cols];

            if (midValue == target)
                return true;
            else if (midValue < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return false;
    }
}
class Program{
    public static void Main()
    {
        int[,] matrix = {
            { 1,  3,  5,  7 },
            { 10, 11, 16, 20 },
            { 23, 30, 34, 60 }
        };

        Console.Write("Enter the target value: ");
        int target = int.Parse(Console.ReadLine());

        bool found = Matrix.SearchMatrix(matrix, target);
        if(found){
            Console.Write(Matrix.SearchMatrix(matrix, target));
        }
        else{
            Console.Write(Matrix.SearchMatrix(matrix, target));
        }
    }
}