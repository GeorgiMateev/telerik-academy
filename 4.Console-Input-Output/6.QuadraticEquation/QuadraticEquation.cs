using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a;
            bool isCorrectA = false;
            do
            {
                Console.Write("a = "); string inA = Console.ReadLine();
                if (double.TryParse(inA, out a))
                {
                    isCorrectA = true;
                }
                else
                {
                    Console.WriteLine("Enter only numbers!");
                    Console.WriteLine();
                }
            }
            while (!isCorrectA);

            double b;
            bool isCorrectB = false;
            do
            {
                Console.Write("b = "); string inB = Console.ReadLine();
                if (double.TryParse(inB, out b))
                {
                    isCorrectB = true;
                }
                else
                {
                    Console.WriteLine("Enter only numbers!");
                    Console.WriteLine();
                }
            }
            while (!isCorrectB);

            double c;
            bool isCorrectC = false;
            do
            {
                Console.Write("c = "); string inC = Console.ReadLine();
                if (double.TryParse(inC, out c))
                {
                    isCorrectC = true;
                }
                else
                {
                    Console.WriteLine("Enter only numbers!");
                    Console.WriteLine();
                }
            }
            while (!isCorrectC);

            List<double?> roots = QuadEquation(a, b, c);
            if (roots[0] == null)
            {
                Console.WriteLine("There is no real roots!");
            }
            else
            {
                Console.WriteLine("x1 = {0}", roots[0]);
                Console.WriteLine("x2 = {0}", roots[1]);
            }

            Console.ReadKey(false);
        }
        
        static List<double?> QuadEquation(double a, double b, double c)
        {
            List<double?> roots = new List<double?>();

            double D = b * b - 4 * a * c;

            if (D < 0)
            {
                roots.Add(null);
                roots.Add(null);
            }
            else
            {
                double root1 = (-b + Math.Sqrt(D)) / 2 * a;
                double root2 = (-b - Math.Sqrt(D)) / 2 * a;
                roots.Add(root1);
                roots.Add(root2);
            }
            return roots;
        }
        
    }
}
