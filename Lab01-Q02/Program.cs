using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Q02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd or Even");
            Console.WriteLine("------------------------");
            Console.WriteLine("Enter 10 Numbers ");
            int num;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
                Console.Write($"Number {i + 1}: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} is Even");
                }
                else
                {
                    Console.WriteLine($"{num} is Odd");
                }
            }
            Console.WriteLine("------------------------");
        }
    }
}