using System;
using System.IO;

class File2{
    public static void Main()
    {
        Console.Write("Enter the file path: ");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            Console.Write("Enter the word to search for: ");
            string searchWord = Console.ReadLine();
            int wordCount = CountWordOccurrences(filePath, searchWord);

            Console.WriteLine($"The word \"{searchWord}\" appears {wordCount} times in the file.");
        }
        else
        {
            Console.WriteLine("File not found. Please check the path and try again.");
        }
    }

    public static int CountWordOccurrences(string filePath, string word)
    {
        int count = 0;
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ', '\t', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string w in words)
                    {
                        if (w.Equals(word, StringComparison.OrdinalIgnoreCase))
                        {
                            count++;
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
        return count;
    }
}

