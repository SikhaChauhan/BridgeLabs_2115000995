using System;
namespace LibrarySystem
{
    public class Library
    {
        public string Title;
        public string Author;
        public decimal Price;
        public bool IsAvailable;

        public Library()
        {
            Title = "Unknown Title";
            Author = "Unknown Author";
            Price = 0.0m;
            IsAvailable = true;
        }

        public Library(string title, string author, decimal price, bool isAvailable = true)
        {
            Title = title;
            Author = author;
            Price = price;
            IsAvailable = isAvailable;
        }

        // Method to Borrow a Book
        public void BorrowBook()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"You have successfully borrowed \"{Title}\" by {Author}.");
            }
            else
            {
                Console.WriteLine($"Sorry, \"{Title}\" by {Author} is currently unavailable.");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Price: Rs.{Price}");
            Console.WriteLine($"Availability: {(IsAvailable ? "Available" : "Not Available")}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library book1 = new Library("Gitanjali", "R.B.Tagore", 500);

            Console.WriteLine("Book Details:");
            book1.Display();

            Console.WriteLine("\nAttempting to borrow the book...");
            book1.BorrowBook();

            Console.WriteLine("\nBook Details After Borrowing:");
            book1.Display();

            Console.WriteLine("\nAttempting to borrow the book again...");
            book1.BorrowBook();
        }
    }
}
