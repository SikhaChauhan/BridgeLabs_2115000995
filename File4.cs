using System;
using System.IO;
class File4
{
    public static void Main()
    {
        string filePath = "UserInput.txt";

        Console.WriteLine("Enter text to save to file (type 'exit' to stop):");
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "exit") break;
                writer.WriteLine(input);
            }
        }

        Console.WriteLine("\nData saved successfully. Reading from file...\n");

        using (StreamReader reader = new StreamReader(filePath))
        {
            string fileContent = reader.ReadToEnd();
            Console.WriteLine("File Content:\n" + fileContent);
        }
    }
}
