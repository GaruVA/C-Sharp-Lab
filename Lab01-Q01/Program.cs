// Write a Console Application Program to calculate the area of a rectangle.
// Prompt the user to enter the length and width.
// Display the calculated area. (use a separate function calculate the area).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Q01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area of a Rectangle");
            Console.WriteLine("---------------------------------");

            // Use meaningful variable names
            Console.Write("Enter Length: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            // Calculate and display the area
            int area = length * width;
            Console.WriteLine($"Area = {area}");

            Console.WriteLine("---------------------------------");
        }
    }
}

