using System;
class Chocolates
{
    // This function finds how many chocolates each child gets and the remaining chocolates
    public static int[] FindRemainderAndQuotient(int ChocoNum, int ChildrenNum)
    {
        int choco_PerChild = ChocoNum / ChildrenNum; 
        int remaining_Choco = ChocoNum % ChildrenNum; 
        return new int[] { choco_PerChild, remaining_Choco };
    }
    static void Main(string[] args)
    {
        Console.Write("Enter the number of chocolates: ");
        int ChocoNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int ChildrenNum = Convert.ToInt32(Console.ReadLine());

        if (ChildrenNum == 0)
        {
            Console.WriteLine("Error: Number of children must be greater than 0.");
            return;
        }

        int[] res = FindRemainderAndQuotient(ChocoNum, ChildrenNum);

        Console.WriteLine($"Each child will get {res[0]} chocolates.");
        Console.WriteLine($"The remaining chocolates are {res[1]}.");
    }
}
