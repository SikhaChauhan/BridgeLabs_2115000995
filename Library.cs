using System;
namespace Library
{
    class Book
    {
        public string Title { get; set; }
        public int PublicationYear { get; set; }

        public Book(string title, int publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }

        // Method to display book details
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Publication Year: {PublicationYear}");
        }
    }

    class Author : Book
    {
        public string Name { get; set; }
        public string Bio { get; set; }

        public Author(string title, int publicationYear, string name, string bio)
            : base(title, publicationYear)
        {
            Name = name;
            Bio = bio;
        }

        // Override DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Author Name: {Name}");
            Console.WriteLine($"Author Bio: {Bio}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Author author = new Author(
                "Gitanjali", 
                1956, 
                "R.B.Tagore", 
                "Indian Famous Poet and Writer."
            );

            Console.WriteLine("Book Information:");
            author.DisplayInfo();
        }
    }
}
