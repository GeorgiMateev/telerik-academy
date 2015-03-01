using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.PointInACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 2;

            int r = 5;

            bool isInsideCircle = x * x + y * y <= r * r;
        }
    }
}
