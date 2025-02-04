using System;
class Book
{
    private static string libraryName = "GLA Central Library";

    public readonly string ISBN;
    public string Title;
    public string Author;

    public static string LibraryName
    {
        get { return libraryName; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                libraryName = value;
                Console.WriteLine($"Library name updated to: {libraryName}");
            }
            else
            {
                Console.WriteLine("Library name cannot be empty.");
            }
        }
    }

    public Book(string Title, string Author, string ISBN)
    {
        this.Title = Title;
        this.Author = Author;
        this.ISBN = ISBN;
    }

    // Static method to display library name
    public static void DisplayLibraryName()
    {
        Console.WriteLine($"Library Name: {libraryName}");
    }

    // Method to display book details using 'is' operator
    public void DisplayBookDetails()
    {
        if (this is Book)
        {
            Console.WriteLine($"Library: {libraryName}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }
}

class Program
{
    static void Main()
    {

        Book book1 = new Book("Gitanjali", "R.B.Tagore", "4657687987676");
        Book book2 = new Book("Half Girlfriend", "Chetan Bhagat", "6798876656788");


        Console.WriteLine("Before Changing Library Name:");
        book1.DisplayBookDetails();
        Console.WriteLine();
        book2.DisplayBookDetails();

        Console.WriteLine("\nChanging Library Name...\n");

 
        Book.LibraryName = "NA Canteen Library";

        Console.WriteLine("\nAfter Changing Library Name:");
        book1.DisplayBookDetails();
        Console.WriteLine();
        book2.DisplayBookDetails();

        Console.WriteLine();

        Book.DisplayLibraryName();
    }
}    