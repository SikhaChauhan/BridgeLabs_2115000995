using System;
public class Book2
{
    public string ISBN;
    protected string Title;
    private string author;

    public Book2(string isbn, string title, string author)
    {
        ISBN = isbn;
        Title = title;
        this.author = author;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }

    public static void Main(string[] args)
    {
        EBook ebook = new EBook("756-1-42-17850-0", "Java Programming", "Krishav");
        ebook.DisplayBookDetails();

        ebook.SetAuthor("Atharv");
        ebook.DisplayBookDetails();
    }
}

public class EBook : Book2
{

    public EBook(string isbn, string title, string author)
        : base(isbn, title, author)
    {
    }

    public void DisplayBookDetails()
    {
        Console.WriteLine($"ISBN: {ISBN}"); 
        Console.WriteLine($"Title: {Title}"); 
        Console.WriteLine($"Author: {GetAuthor()}"); 
		Console.WriteLine();
    }
}
