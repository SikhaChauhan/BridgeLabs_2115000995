using System;
using System.IO;
using System.Text;

class File3{
    public static void Main()
    {
        Console.Write("Enter the binary file path: ");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string content = reader.ReadToEnd();
                    Console.WriteLine("\nFile Content:\n" + content);
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
