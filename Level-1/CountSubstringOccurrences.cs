using System;
class CountSubstringOccurrences
{
    // Function to count occurrences of a substring in a string without using built-in functions
    static int Substr_Occurrences(string str, string substr)
    {
        int cnt = 0;

        for (int i = 0; i <= str.Length - substr.Length; i++)
        {
            bool flag = true;

            for (int j = 0; j < substr.Length; j++)
            {
                if (str[i + j] != substr[j])
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
            {
                cnt++;
            }
        }

        return cnt;
    }

    static void Main()
    {
        Console.Write("Enter the main string: ");
        string newStr = Console.ReadLine();

        Console.Write("Enter the substring to search for: ");
        string substr = Console.ReadLine();

        int cnt = Substr_Occurrences(newStr, substr);

        Console.WriteLine($"The substring '{substr}' occurs {cnt} times in the main string.");
    }
}
