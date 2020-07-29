using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

// TODOS
// getters and setters for accounts and customers
namespace BankApplication
{
    class Bank
    {
        private int accountNumber = 1234567890;
        public Bank(Customer customer, decimal initialDeposit, string accountType, DateTime date)
        {
            CustomerName = $"{customer.FirstName} {customer.LastName}";
            AccountNumber = accountNumber;
            AccountBalance = initialDeposit;
            AccountType = accountType;
            Date = date;
            Note = "Initial Deposit";
            
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

    }
}
