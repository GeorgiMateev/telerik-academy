using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.CircleSP
{
    class Circle
    {
        static void Main(string[] args)
        {
            int r = 0;
            double area = 0;
            double perimeter = 0;

            bool isCorrectIn = false;
            do
            {
                Console.Write("r = ");
                isCorrectIn = int.TryParse(Console.ReadLine(), out r);
                if (isCorrectIn)
                {
                    area = Math.PI * r * r;
                    perimeter = 2 * Math.PI * r;
                }
                else
                {
                    Console.WriteLine("Enter only numbers!");
                    Console.WriteLine();
                }
            }
            while (!isCorrectIn);
            Console.WriteLine("S = {0:F3}; P = {1:F3}",area,perimeter);

            Console.ReadKey(false);
        }
    }
}
