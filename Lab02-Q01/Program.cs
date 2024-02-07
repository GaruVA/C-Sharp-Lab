using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Q01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();
            myBook.title = "The Seven Moons of Maali Almeida";
            myBook.author = "Shehan Karunatilaka";
            Console.WriteLine($"Book Title: {myBook.title}");
            Console.WriteLine($"Book Author: {myBook.author}");
        }
    }
    class Book
    {
        public string title;
        public string author;
    }
}
