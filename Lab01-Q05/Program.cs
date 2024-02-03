//Write a Console Application program to display the multiplication table of a given number.
//Prompt the user to enter a number and display its multiplication table. (Use loops)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Q05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Table of N");
            Console.WriteLine("-------------------------");
            Console.Write("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
            Console.WriteLine("-------------------------");
        }
    }
}
