using System;
class RevString
{
    // Function to reverse the string
    static string rev_string(string str)
    {
        char[] charArr = str.ToCharArray(); 
        int s = 0;
        int e = charArr.Length - 1;

        while (s < e)
        {
            // Swap characters
            char temp = charArr[s];
            charArr[s] = charArr[e];
            charArr[e] = temp;

            s++;
            e--;
        }
        return new string(charArr);
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string revString = rev_string(input);

        Console.WriteLine($"Reversed string: {revString}");
    }
}
