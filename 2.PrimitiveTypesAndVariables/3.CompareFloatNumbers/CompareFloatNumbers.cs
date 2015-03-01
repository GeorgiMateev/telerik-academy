using System;

namespace _3.CompareFloatNumbers
{
    class CompareFloatNumbers
    {
        static void Main()
        {
            float a = 0.00000003F;
            float b = 0.00000002F;

            if (a > b)
            {
                Console.WriteLine("a>b");
            }
            else
            {
                Console.WriteLine("a<b");
            }

            Console.ReadKey(false);
        }
    }
}
