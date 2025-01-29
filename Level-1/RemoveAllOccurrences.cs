using System;
class RemoveAllOccurrences
{
    // Function to remove all occurrences of a specific character from a string
    static string Remove_Char(string str, char removeChar)
    {
        char[] res = new char[str.Length];
        int idx = 0;
		
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] != removeChar)
            {
                res[idx] = str[i];
                idx++;
            }
        }

        string newStr = "";
        for (int i = 0; i < idx; i++)
        {
            newStr += res[i];
        }

        return newStr;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.Write("Enter the character to remove: ");
        char removeChar= Console.ReadKey().KeyChar;
        Console.WriteLine();

        string newStr = Remove_Char(input, removeChar);

        Console.WriteLine($"Modified String: \"{newStr}\"");
    }
}
