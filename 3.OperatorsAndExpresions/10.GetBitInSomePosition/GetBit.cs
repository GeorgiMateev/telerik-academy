using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.GetBitInSomePosition
{
    class GetBit
    {
        static void Main(string[] args)
        {
            int v = 2;
            int p = 1;

            int mask = 1;
            mask <<= p;

            int numberWithMask = v & mask;
            numberWithMask >>= p;

            bool isOne = numberWithMask == 1;
        }
    }
}
