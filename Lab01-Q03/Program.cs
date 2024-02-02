//Write a Console Application program to calculate the sum of all numbers from 1 to a given positive integer,
//Prompt the user to enter a positive integer and display the sum.
//if the user inputs a negative value it should display "ERROR".


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Q03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of Numbers 1 to N");
            Console.WriteLine("------------------------");
            Console.Write("Enter Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine();
            if (n < 0)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.WriteLine($"Sum = {sum}");
            }
            Console.WriteLine("------------------------");
        }
    }
}
