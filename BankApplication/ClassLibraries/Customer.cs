using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

// This class hold properties of the customer
namespace BankApplication
{
    public class Customer 
    {
        private static int id = 1;
        public Customer(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UniqueId = id;
            id++;
        }

        public int UniqueId { get;  }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public List<Customer> AllCustomer = new List<Customer>();

      



    }
}
