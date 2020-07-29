using System;
using System.Collections.Generic;
using System.Text;
//This class holds the fields necessary for implementing transactions in this bank app.

// create class login details that has username and password fields (private with getters and setters)
namespace BankApplication
{
   public class Transactions
    {
        public Transactions(decimal amount, DateTime date, string note)
        {

        }
        public decimal Amount { get; }
        public string transactionType { get; }
        public string note { get; }
        public
            DateTime date { get; }


    }
}
