using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Bank
{
    class Deposit : Account
    {
        public Deposit(Customer owner, decimal balance, decimal interestRate)
            : base(owner, balance, interestRate)
        {

        }

        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        public void WithDrawMoney(decimal money)
        {
            this.Balance -= money;
        }

        /// <summary>
        /// Calculates the interest amount for period in months.
        /// </summary>
        /// <param name="period">The period in months.</param>
        public override decimal GetInterestAmount(int period)
        {
            if (this.Balance>0 && this.Balance<1000)
            {
                return 0;
            }

            decimal amount = period * this.InterestRate;
            return amount;
        }
    }
}
