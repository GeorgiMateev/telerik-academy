using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.ExtractBitValue
{
    class ExtractBitValue
    {
        static void Main(string[] args)
        {
            int i = 5;
            int b = 2;

            int mask = 1;
            mask <<= b;

            int numberWithMask = i & mask;
            int value = numberWithMask >>= b;
            
        }
    }
}
