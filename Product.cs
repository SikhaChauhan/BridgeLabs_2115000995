using System;
namespace ProductInventory
{
    public class Product
    {
        public string ProductName;
        public decimal Price;

        private static int totalProducts = 0;

        public Product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
            totalProducts++;
        }

        // Instance Method to Display Product Details
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Price: Rs.{Price}");
        }

        // Class Method to Display Total Products
        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"Total Products Created: {totalProducts}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Watch", 1900.99m);
            Product product2 = new Product("Car", 779999.49m);
            Product product3 = new Product("Bottle", 299.99m);

            Console.WriteLine("Product 1 Details:");
            product1.DisplayProductDetails();

            Console.WriteLine("\nProduct 2 Details:");
            product2.DisplayProductDetails();

            Console.WriteLine("\nProduct 3 Details:");
            product3.DisplayProductDetails();

            Console.WriteLine("\nTotal Products Information:");
            Product.DisplayTotalProducts();
        }
    }
}
