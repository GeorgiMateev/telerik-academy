using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.AdvancedBitExchange
{
    class AdvancedBitExchange
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("n = "); n = int.Parse(Console.ReadLine());
            int p;
            Console.Write("p = "); p = int.Parse( Console.ReadLine());
            int q;
            Console.Write("q = "); q = int.Parse(Console.ReadLine());
            int k;
            Console.Write("k = "); k = int.Parse(Console.ReadLine());
            
            int m = n;

            for (int i = 0; i < k; i++)
            {
                int bit = GetBit(m, q + i);
                ModifyBit(ref n, p + i, bit);
            }

            Console.WriteLine("Modified n = {0}",n);

            Console.ReadKey(false);

        }
        private static void ModifyBit(ref int n, int bitPosition, int bit)
        {
            if (bit == 1)
            {
                int mask = 1;
                mask <<= bitPosition;
                n = n | mask;
            }

            if (bit == 0)
            {
                int mask = 1;
                mask <<= bitPosition;
                mask = ~mask;
                n = n & mask;
            }
        
        }
        private static int GetBit(int n, int bitPosition)
        {
            int mask = 1;
            mask <<= bitPosition;
            int bit = n & mask;
            bit >>= bitPosition;
            return bit;
        }
    }
}
