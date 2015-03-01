using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Bank
{
    class Loan : Account
    {
        public Loan(Customer owner, decimal balance, decimal interestRate)
            : base(owner, balance, interestRate)
        {
        }

        public void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

        /// <summary>
        /// Calculates the interest amount for period in months.
        /// </summary>
        /// <param name="period">The period in months.</param>
        public override decimal GetInterestRate(int period)
        {
            if (Owner.IsCompany && period<=2)
            {
                return 0;
            }
            if (!Owner.IsCompany && period<=3)
            {
                return 0;
            }
            decimal amount = this.InterestRate * period;
            return amount;
        }
    }
}
