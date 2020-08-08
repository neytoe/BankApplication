using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Start:
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Welcome to the Bank of Wealth");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Please Select what you would like to do below");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("\t To create a new Account, PRESS 'C' \n\t\t To Sign into an Accont PRESS 'S' \n\t\t\t To end this Process PRESS 'E'");
            Console.WriteLine("------------------------------------------------------------------");


            string choices = Console.ReadLine().ToLower();

            if (choices == "e")
            {
                goto End;
            }

            if (choices == "c")

            {
                Console.WriteLine("Please Enter your firstName");
                string firstName = Console.ReadLine();
                Console.WriteLine("Please Enter your lastName");
                string lastName = Console.ReadLine();
                Console.WriteLine("Please Enter your Email");
                string email = Console.ReadLine();
                Customer currentCustomer = new Customer(firstName, lastName, email);
                Console.WriteLine("Please Enter the amount you would like to deposit");
                decimal amount = decimal.Parse(Console.ReadLine());
                Console.WriteLine("What type of account would you like to open?\n\t\tType in 'S' for savings account\n\t\tType in 'C' for current account");
                string accountType = Console.ReadLine().ToLower() == "s" ? "savings" : "current";
                Bank currnentAccount = new Bank(currentCustomer, amount, accountType, DateTime.Now);
                Console.WriteLine($"A {currnentAccount.AccountType} account has been created for {currnentAccount.CustomerName} with {currnentAccount.AccountBalance} on {currnentAccount.Date}");
                Console.WriteLine("type 'C' to continue");
                string choice = Console.ReadLine();
                if (choice.ToLower() == "c")
                    goto Start;
            }

            

        // Runs the end of the program
        End:
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("------------------Thank you for banking with us!--------------------------------");




            
        }
    }
}
