using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.CheckForPrimeNumber
{
    class CheckForPrimeNumber
    {
        static void Main(string[] args)
        {
            int n = 97;
            bool isDivisibleBy2 = n % 2 == 0;
            bool isDivisibleBy3 = n % 3 == 0;
            bool isDivisibleBy5 = n % 5 == 0;
            bool isDivisibleBy7 = n % 7 == 0;

            bool isPrime = !isDivisibleBy2 && !isDivisibleBy3 && !isDivisibleBy5 && !isDivisibleBy7;
        }
    }
}
