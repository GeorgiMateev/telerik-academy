using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.IEnumerable_Extensions
{
    class TestExtension
    {
        public static void Main()
        {
            List<double> collection = new List<double> { 3, 5, 3, 43, 34.5, 324.6, 34.6, 6.3, 435, 5.6, 5.4, 3.7878, 3.346, 34, 4.42, 5.23545, 0.34, 53.5, 3.45, 54, 0.35 };

            Console.WriteLine("Sum = {0}", collection.Sum());
            Console.WriteLine("Product = {0}", collection.Product());
            Console.WriteLine("Average = {0}", collection.Average());
            Console.WriteLine("Min = {0}", collection.Minimum());
            Console.WriteLine("Max = {0}", collection.Maximum());

            Console.ReadKey();
        }
    }
}
