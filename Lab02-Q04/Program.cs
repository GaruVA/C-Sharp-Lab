// Construct a C# program for a basic inventory system.
// Define a class named Product with properties ProductName and Price.
// Implement a parameterized constructor to initialize these properties.
// Instantiate objects using the constructor and display the product details.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Q04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product("Kar98k - Scoped", 1000000);
            Console.WriteLine($"Product Name: {product.ProductName}");
            Console.WriteLine($"Price: {product.Price}");
        }
    }
    class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public Product(string ProductName, decimal Price) 
        { 
            this.ProductName = ProductName;
            this.Price = Price;
        }
    }
}
