using System;
class SentenceWithWord{
    public static string FindSentenceWithWord(string[] sentences, string word)
    {
        foreach (string sentence in sentences)
        {
            if (sentence.Contains(word, StringComparison.OrdinalIgnoreCase))
                return sentence;
        }
        return "No sentence contains the given word.";
    }
}
class Program
{
    public static void Main()
    {
        Console.Write("Enter sentences (separated by '|'): ");
        string[] sentences = Console.ReadLine().Split('|');

        Console.Write("Enter the word to search for: ");
        string word = Console.ReadLine();

        string result = SentenceWithWord.FindSentenceWithWord(sentences, word);
        Console.WriteLine($"Result: {result}");
    }
}