using System;
class Toggle
{
    // Function to toggle the case of each character in a string
    static string Toggle_case(string str)
    {
        char[] toggle_Str = new char[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            char curr_Char = str[i];
            if (curr_Char >= 'A' && curr_Char <= 'Z')
            {
                toggle_Str[i] = (char)(curr_Char + 32);
            }
            else if (curr_Char >= 'a' && curr_Char <= 'z')
            {
                toggle_Str[i] = (char)(curr_Char - 32);
            }
            else
            {
                toggle_Str[i] = curr_Char;
            }
        }
        return new string(toggle_Str);
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string res = ToggleCase(input);

        Console.WriteLine($"String after toggling case: {res}");
    }
}
