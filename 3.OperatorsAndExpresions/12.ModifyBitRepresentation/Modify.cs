using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.ModifyBitRepresentation
{
    class Modify
    {
        static void Main(string[] args)
        {
            int n = 5;
            int v = 0;
            int p = 2;

            if (v == 1)
            {
                int mask = 1 << p;
                n = n | mask;
            }

            if (v == 0)
            {
                int mask = ~(1 << p);
                n = n & mask;
            }
        }
    }
}
