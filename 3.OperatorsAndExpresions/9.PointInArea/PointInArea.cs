using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9.PointInArea
{
    class PointInArea
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y = 2;

            int cX = 1;
            int cY = 1;
            int r = 3;

            bool isInsideCircle = (x - cX) * (x - cX) + (y - cY) * (y - cY) <= r * r;
            bool isInsideRectangle = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);

            bool isInGivenArea = isInsideCircle && !isInsideRectangle;
        }
    }
}
