using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Bank
{
    abstract class Account
    {
        private Customer owner;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer owner, decimal balance, decimal interestRate)
        {
            this.owner = owner;
            this.balance = balance;
            this.interestRate = interestRate;
        }

        public Customer Owner
        {
            get { return this.owner; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            protected set { this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
        }

        public abstract decimal GetInterestRate();
    }
}
