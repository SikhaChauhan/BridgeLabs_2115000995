using System;
class FindLongestWord
{
    // Function to find the longest word in a sentence
    static string Longest_Word(string str)
    {
        string[] words = str.Split(' ');

        string longest_word = "";
        int maxLen = 0;

        foreach (string word in words)
        {
            if (word.Length > maxLen)
            {
                maxLen = word.Length;
                longest_word = word;
            }
        }

        return longest_word;
    }

    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();

        string longest_word = Longest_Word(input);

        Console.WriteLine($"The longest word in the sentence is: {longest_word}");
    }
}
