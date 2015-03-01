using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.Human
{
    class Worker : Human
    {
        private decimal weekSalary;
        public decimal WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; }
        }

        private int workHoursPerDay;
        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursperDay)
            : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursperDay;
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerDay = this.weekSalary / 5;
            return moneyPerDay / this.workHoursPerDay;
        }


        public override string ToString()
        {
            return String.Format("{0} {1} Money per hour: {2:0.00}", this.FirstName, this.LastName, this.MoneyPerHour());
        }
    }
}
