// Imagine you are developing a console application to manage a shop's inventory.
// Design a class named "Product" to encapsulate product details while utilizing access specifiers appropriately.
// A parameterized constructor that initializes productId, productName, price, and quantityInStock when an object is created.
//	
//	Product CLASS
//	- productId (int)
//	- productName (String)
//	- price (double)
//	- quantityInStock (int)
//	+ AddProduct()
//	+ BuyProduct()
//	
// a) Create an instance of the "Product" class, representing a product with an ID of 101, name "Laptop," price $800, and quantity in stock 10.
// b) Access and display the name, price, and quantity of the product.
// c) Attempt to modify the product's ID from external code (outside the class). Observe and comment on the result.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Q03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(101, "Laptop", 800.00, 10);
            product.DisplayProduct();

            // product.productID = 102; // Property 'productID' cannot be assigned to -- it is read only
        }
    }
    class Product
    {
        private int productID;
        private string productName;
        private double price;
        private int quantityInStock;

        public void AddProduct(int quantity)
        {
            this.quantityInStock += quantity;
            Console.WriteLine($"{quantity} {productName}(s) added to stock. Total quantity in stock = {this.quantityInStock}");
        }

        public void  BuyProduct(int quantity)
        {
            if (this.quantityInStock > quantity)
            {
                this.quantityInStock -= quantity;
                Console.WriteLine($"{quantity} {productName}(s) sold. Remaining quantity in stock = {this.quantityInStock}");
            }
            else
            {
                Console.WriteLine($"Insufficient stock!. Only {this.quantityInStock} {productName}(s) available");
            }
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"Product ID: {productID}");
            Console.WriteLine($"Product Name: {productName}");
            Console.WriteLine($"Price: ${price}");
            Console.WriteLine($"Quantity in Stock: {quantityInStock}");
        }

        public Product(int productID, string productName, double price, int quantityInStock)
        {
            this.productID = productID;
            this.productName = productName;
            this.price = price;
            this.quantityInStock = quantityInStock;
        }
    }
}
