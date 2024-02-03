//	7. Write a Console Application program to simulate a basic ATM machine.
//	Allow the user to check balance, deposit money, and withdraw money.
//	Display appropriate messages based on user actions (Create separate functions for individual operations).



using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Q07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ABC BANK");
            int balance = 10000;
            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("1 - Check Balance");
                Console.WriteLine("2 - Deposit Money");
                Console.WriteLine("3 - Withdraw Money");
                Console.WriteLine("4 - Exit");
                Console.WriteLine("------------------------------------------");
                Console.Write("Enter Choice: ");
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------");
                if (choice == 1)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine($"Your current balance is {balance}.");
                    Console.WriteLine("------------------------------------------");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine($"Please enter the amount you would like to deposit.");
                    Console.Write("Amount: ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    balance += amount;
                    Console.WriteLine();
                    Console.WriteLine($"Your deposit of {amount} has been successfully processed.");
                    Console.WriteLine($"Your new balance is {balance}.");
                    Console.WriteLine("------------------------------------------");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine($"Please enter the amount you would like to withdraw.");
                    Console.Write("Amount: ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine($"Processing withdrawal of {amount}...");
                    if (balance < amount)
                    {
                        Console.WriteLine($"Insufficient funds. Your current balance is {balance}.");
                    }
                    else
                    {
                        balance -= amount;
                        Console.WriteLine($"Withdrawal successful. Your new balance is {balance}.");
                    }
                    Console.WriteLine("------------------------------------------");
                }
                else if (choice == 4)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Thank you using our bank.");
                    Console.WriteLine("------------------------------------------");
                }
                else
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Invalid Choice!");
                    Console.WriteLine("------------------------------------------");
                }
            }
        }
    }
}
