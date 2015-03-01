using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.FormatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            double n = double.Parse(Console.ReadLine());

            string asDecimal = String.Format("{0,15:D5}", (int)n);
            Console.WriteLine(asDecimal);

            string asExp = String.Format("{0,15:E}", n);
            Console.WriteLine(asExp);

            string asHex = String.Format("{0,15:X}", (int)n);
            Console.WriteLine(asHex);

            string asPerc = String.Format("{0,15:P}", n);
            Console.WriteLine(asPerc);

            Console.ReadKey();
        }
    }
}
