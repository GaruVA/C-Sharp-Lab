//Develop an application that simulates a library system.
//Create a class named LibraryBook with properties Title, Author, and Available.
//Implement a method BorrowBook that updates the availability status.
//Instantiate multiple book objects, perform book borrowing, and display the updated library status.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Q05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryBook book1 = new LibraryBook();
            book1.Title = "To Kill a Mockingbird";
            book1.Author = "Harper Lee";
            book1.Available = true;
            LibraryBook book2 = new LibraryBook();
            book2.Title = "The Hitchhiker's Guide to the Galaxy";
            book2.Author = "Douglas Adams";
            book2.Available = false;
            LibraryBook book3 = new LibraryBook();
            book3.Title = "The Lord of the Rings";
            book3.Author = "J.R.R. Tolkien";
            book3.Available = true;
            book1.BorrowBook();
            book2.BorrowBook();
            DisplayLibraryStatus(new List<LibraryBook> { book1, book2, book3 });
        }
        static void DisplayLibraryStatus(List<LibraryBook> books)
        {
            Console.WriteLine("Library Status:");

            foreach (LibraryBook book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available: {book.Available}");
            }
        }
    }
    class LibraryBook
    {
        public string Title {  get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }
        public void BorrowBook() 
        {
            if(Available)
            {
                Available = false;
            }
            else
            {
                Console.WriteLine($"{Title} has been booked already!");
            }
        }
    }
}
