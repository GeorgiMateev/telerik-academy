using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.CheckTheThirdBit
{
    class CheckTheThirdBit
    {
        static void Main(string[] args)
        {
            int n = 8699;
            int mask = 1;
            mask <<= 3;

            int numberWithMask = n & mask;
            numberWithMask >>= 3;

            bool isOne = numberWithMask == 1;
        }
    }
}
