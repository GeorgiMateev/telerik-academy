using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.TheThirdDigit
{
    class TheThirdDigit
    {
        static void Main(string[] args)
        {
            int n = 234789;
            n /= 100;
            bool isThirdDigit7 = n % 10 == 7;
        }
    }
}
