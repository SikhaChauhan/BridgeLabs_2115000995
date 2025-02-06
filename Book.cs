using System;
using System.Collections.Generic;
class Book {
    public string title;
    public string auhtor;

    public int ISBN;

    public Book(string t, string a, int i) {
        this.title = t;
        this.auhtor = a;
        this.ISBN = i;
    }

    public void DisplayBook() {
        Console.WriteLine($"Title: {title}, Author: {auhtor}, ISBN: {ISBN}");
    }
}

class Library {
    public string name { get; }
    public List<Book> books;

    public Library(string name) {
        this.name = name;
        books = new List<Book>();
    }

    public void AddBook(Book book) {
        books.Add(book);
    }

    public void DisplayBooks() {
        Console.WriteLine($"\nLibrary: { name }");
        if(books.Count == 0) {
            Console.WriteLine("No books in the library.");
            return;
        }

        foreach(var book in books) {
            book.DisplayBook();
        }
    }

}

class Program {
    public static void Main(string[] args) {
        Library library = new Library("My Library");
       
        Book book1 = new Book("Gitanjali", "R.B.Tagore", 748648293);
        Book book2 = new Book("Half Girlfriend", "Chetan Bhagat", 946374529);
        Book book3 = new Book("2 States", "Chetan Bhagat", 648364836);

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        library.DisplayBooks();
    }
}

