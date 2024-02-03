//Write a Console Application program to print the first N terms of the Fibonacci series
//Prompt the user to enter the value of N. (Use recursion)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Q04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Sequence");
            Console.WriteLine("------------------");
            Console.Write("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < num; i++)
            {
                Console.Write(Fibonacci(i));
                Console.Write(", ");
            }
            Console.WriteLine(Fibonacci(num));
            Console.WriteLine("------------------");
        }
        static int Fibonacci(int num)
        {
            if (num <= 1)
            {
                return num;
            }
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
    }
}
