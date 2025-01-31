using System;

namespace BookDetails
{
    class Book
    {
        private string title;
        private string author;
        private double price;
		
        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        // Method to display book details
        public void Display()
        {
            Console.WriteLine("Book Details:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price:C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter the book author: ");
            string author = Console.ReadLine();
            Console.Write("Enter the book price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            Book book = new Book(title, author, price);
            book.Display();
        }
    }
}
