using System;
class VowelConsonant
{
    // Function to count vowels
    static int Cnt_Vowels(string str)
    {
        int vowel_cnt = 0;
        foreach (char c in str.ToLower())
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                vowel_cnt++;
            }
        }
        return vowel_cnt;
    }

    // Function to count consonants
    static int Cnt_Conso(string str)
    {
        int conso_cnt = 0;
        foreach (char c in str.ToLower())
        {
            if (char.IsLetter(c) && (c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u'))
            {
                conso_cnt++;
            }
        }
        return conso_cnt;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string inp = Console.ReadLine();

        int vowel_cnt = Cnt_Vowels(inp);
        int conso_cnt = Cnt_Conso(inp);

        Console.WriteLine($"Number of vowels: {vowel_cnt}");
        Console.WriteLine($"Number of consonants: {conso_cnt}");
    }
}
