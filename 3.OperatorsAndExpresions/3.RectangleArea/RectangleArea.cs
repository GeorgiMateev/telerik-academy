using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int area = a * b;

            Console.WriteLine(area);

            Console.ReadKey(false);
        }
    }
}
