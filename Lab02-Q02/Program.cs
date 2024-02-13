//Develop a console program that models a simple bank account.
//Create a class named 'BankAccount' with properties AccountNumber and Balance.
//Implement a method 'Deposit' that allows the user to deposit money into the account.
//Instantiate an object, perform a deposit, and display the updated balance.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Q02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BackAccount account = new BackAccount();
            account.AccountNumber = 123456789;
            account.Balance = 5000;
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Initial Balance: {account.Balance}");
            Console.WriteLine("Enter the amount to deposit:");
            account.Deposit(Convert.ToDecimal(Console.ReadLine()));
        }
    }
    class BackAccount
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public void Deposit (decimal amount)
        {
            if(Balance > 0) 
            {
                Balance += amount;
                Console.WriteLine($"Deposit Successful.");
                Console.WriteLine($"New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine($"Deposit should be more than 0.");
            }

        }
    }
}
