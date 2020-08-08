using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

// TODOS
// getters and setters for accounts and customers
namespace BankApplication
{       //This class performs the basic functions in the bank.
    class Bank
    {
        private int accountNumber = 1234567890;

        //Constructor for the Bank
        public Bank(Customer customer, decimal initialDeposit, string accountType, DateTime date)
        {
            CustomerName = $"{customer.FirstName} {customer.LastName}";
            AccountNumber = accountNumber;
            AccountBalance = initialDeposit;
            AccountType = accountType;
            Date = date;
            Note = "Initial Deposit";
            
            AllCustomers.Add(customer);
            MakeDeposit(initialDeposit, customer, "Inital Deposit");
            accountNumber++;
        }

        public string CustomerName {get; }
        public int AccountNumber { get; }
        public decimal AccountBalance { get; set; }
        public string AccountType { get; }
        public DateTime Date { get; }
        public string Note { get; }
        
      public  List<Transactions> AllTransactions = new List<Transactions>();
        List<Accounts> AllAccounts = new List<Accounts>();
        List<Customer> AllCustomers = new List<Customer>();
        List<Bank> AllBankAccounts = new List<Bank>();


        public void MakeDeposit(decimal amount, Customer customer, string note)
        {
            while (amount < 1)
            {
                Console.WriteLine("Please enter a value greater than 0");
            }

            AccountBalance += amount;
            AllTransactions.Add(new Transactions(amount, DateTime.Now, note));




        }

        //This method implemen ts a withdrawal transaction
        public void MakeWithDrawal(decimal amount, Customer customer, string note)
        {
            while (amount < 1)
            {
                Console.WriteLine("Please enter a value greater than 0");
            }
            AccountBalance -= amount;
            AllTransactions.Add(new Transactions(amount, DateTime.Now, note));

        }

        //This method implements a transfer transfer transaction
        public void MakeTransfer()
        {

        }


        //This method checks and hands out the current balance of the customer
        public void CheckBalance()
        {

        }
    }
}
