using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15.Fraction
{
    class Test
    {
        static void Main()
        {
            string fr = Console.ReadLine();
            Fraction f = Fraction.Parse(fr);

            Console.WriteLine(f.ToString());

            Console.ReadKey();
        }
    }
}
