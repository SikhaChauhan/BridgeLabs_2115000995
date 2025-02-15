using System;
using System.IO;
class File1
{
    public static void Main()
    {
        Console.Write("Enter the file path: ");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
        else
        {
            Console.WriteLine("File not found. Please check the path and try again.");
        }
    }
}
