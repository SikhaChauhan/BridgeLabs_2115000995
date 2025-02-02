using System;
namespace BookNamespace
{
    public class Book
    {
        public string Title;
        public string Author;
        public decimal Price;
		
        public Book()
        {
            Title = "something...";
            Author = "something...";
            Price = 0.0M;
        }

        public Book(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Price: {Price:C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Console.WriteLine("Default Constructor Book:");
            book1.Display();

            Console.WriteLine();
            Book book2 = new Book("Gitanjali", "R.B.Tagore", 500);
            Console.WriteLine("Parameterized Constructor Book:");
            book2.Display();
        }
    }
}
