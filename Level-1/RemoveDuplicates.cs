using System;
class RemoveDuplicates
{
    // Function to remove duplicate characters from a string
    static string Remove_Dupli(string str)
    {
        char[] res = new char[str.Length];
        int idx = 0;

        for (int i = 0; i < str.Length; i++)
        {
            bool isDupli = false;
            for (int j = 0; j < idx; j++)
            {
                if (str[i] == res[j])
                {
                    isDupli = true;
                    break;
                }
            }
            if (!isDupli)
            {
                res[idx] = str[i];
                idx++;
            }
        }
        return new string(res, 0, idx);
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string newStr = Remove_Dupli(input);
        Console.WriteLine($"String after removing duplicates: {newStr}");
    }
}
