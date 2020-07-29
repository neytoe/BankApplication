using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

// Change all methods back to TitleCase
// makeDeposit, makeWithDrawals, makeTranfers
namespace BankApplication
{
    public class Accounts
    {
        public Accounts(string TypeOfAccount, Customer owner)
        { 
            this.TypeOfAccount = this.TypeOfAccount;
            this.AccountNo = NumberSeed.ToString();
            NumberSeed++;
            this.Owner = owner;
            if (string.Equals(this.TypeOfAccount, "savings")) {
                this.Balance = 100;
            } else
            {
                this.Balance = 1000;
            }
        }

        private static int  NumberSeed= 1234567890;
        public  decimal Balance { get; set; }
        public DateTime DateCreated { get; set; }

        public string AccountNo { get; set; }

        public string TypeOfAccount { get; set; }

        public string Note { get; set; }

        private Customer Owner { get; set; }
        

        //This method implements a deposit transaction
        public void MakeDeposit(decimal amount, Customer customer, string note)
        {
            while (amount < 1)
            {
                Console.WriteLine("Please enter a value greater than 0");
            }
            Balance += amount;

            
            Transactions transaction = new Transactions();
            
            
        }

        //This method implemen ts a withdrawal transaction
        public void MakeWithDrawal(decimal amount)
        {

        }

        //This method implements a transfer transfer transaction
        public void MakeTransfer()
        {

        }
    }
}
