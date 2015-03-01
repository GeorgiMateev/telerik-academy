using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.TriangleArea
{
    public class Triangle
    {
        /// <summary>
        /// Finds the area of a triangle with given one side and altitude.
        /// </summary>
        /// <param name="side"></param>
        /// <param name="altitude"></param>
        /// <returns></returns>
        public static double FindArea(double side, double altitude)
        {
            return (side * altitude) / 2;
        }

        /// <summary>
        /// Finds the area of a triangle with given three sides.
        /// </summary>
        /// <param name="a">Side 1</param>
        /// <param name="b">Side 2</param>
        /// <param name="c">Side 3</param>
        /// <returns></returns>
        public static double FindArea(double a, double b, double c)
        {
            bool isImpossible = a+b <=c || a+c<=b || b+c<=a;
            if (isImpossible)
            {
                throw new ArgumentException("Triangle with this sides does not exist!");
            }

            double p = (a+b+c)/2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        /// <summary>
        /// Finds the area of a triangle.
        /// </summary>
        /// <param name="a">First side.</param>
        /// <param name="b">Second side.</param>
        /// <param name="angle">The angle between the sides in degrees.</param>
        /// <returns></returns>
        public static double FindArea(double a, double b, decimal angle)
        {
            bool isCorrectAngle = angle >= 0 && angle <= 180;
            if (!isCorrectAngle)
            {
                throw new ArgumentException("Angle is incorect!");
            }

            double angleRad = ((double)angle*Math.PI/180);
            return a * b * Math.Sin(angleRad) / 2;            
        }

        static void Main()
        {
        }
    }
}
