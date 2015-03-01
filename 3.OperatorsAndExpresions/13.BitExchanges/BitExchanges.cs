using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13.BitExchanges
{
    class BitExchanges
    {
        static void Main(string[] args)
        {
            uint n = 117440512;
    
            uint mask = 1;
            mask <<= 24;
            uint bitP24 = (n & mask) >> 24;

            mask <<= 1;
            uint bitP25 = (n & mask) >> 25;

            mask <<= 1;
            uint bitP26 = (n & mask) >> 26;

            n = ModifyBit(n, 3, bitP24);
            n = ModifyBit(n, 4, bitP25);
            n = ModifyBit(n, 5, bitP26);

        }

        private static uint ModifyBit(uint n,int bitPosition, uint bit)
        {
            if (bit == 1)
            {
                uint mask = 1;
                mask <<= bitPosition;
                n = n | mask;
            }

            if (bit == 0)
            {
                uint mask = 1;
                mask <<= bitPosition;
                mask = ~mask;
                n = n & mask;
            }
            return n;
        }
    }
}
