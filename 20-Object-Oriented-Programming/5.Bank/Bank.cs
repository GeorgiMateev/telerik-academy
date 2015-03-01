using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Bank
{
    class Bank
    {
        private List<Customer> customers;
        private List<Account> accounts;

        public Bank()
        {
            this.customers = new List<Customer>();
            this.accounts = new List<Account>();
        }

        public List<Customer> Customers
        {
            get { return this.customers; }
        }

        public List<Account> Accounts
        {
            get { return this.accounts; }
        }
    }
}
