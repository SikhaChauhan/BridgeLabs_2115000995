using System;
class MostFrequentCharacter
{
    // Function to find the most frequent character in a string
    static char Freq_Char(string str)
    {
        int[] freq = new int[256]; 

        for (int i = 0; i < str.Length; i++)
        {
            freq[(int)str[i]]++;
        }

        int maxFreq = 0;
        char mostFreqChar = '\0';
        for (int i = 0; i < freq.Length; i++)
        {
            if (freq[i] > maxFreq)
            {
                maxFreq = freq[i];
                mostFreqChar = (char)i;
            }
        }

        return mostFreqChar;
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char mostFreqChar = Freq_Char(input);

        Console.WriteLine($"Most Frequent Character: '{mostFreqChar}'");
    }
}
