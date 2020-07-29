using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;
using System.Text.Json.Serialization;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Bank bank = new Bank();
            Customer customer = bank.CreateAccount("Netochukwu", "Anyankah", "nanyankah@gmail.com", "savings");
            Console.WriteLine(customer.FirstName, customer.Email);
            customer.accounts.ForEach(i => Console.WriteLine( i.AccountNo));
            string json = JsonConv
            
           

        }
    }
}
