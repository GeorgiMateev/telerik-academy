using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.Bank
{
    class Customer
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool isCompany;
        public bool IsCompany
        {
            get { return isCompany; }
            set { isCompany = value; }
        }

        public Customer(string name, bool isCompany)
        {
            this.name = name;
            this.isCompany = isCompany;
        }
    }
}
