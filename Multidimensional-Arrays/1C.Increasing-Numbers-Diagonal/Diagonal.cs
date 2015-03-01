using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1C.Increasing_Numbers_Diagonal
{
    class Diagonal
    {
        static void Main(string[] args)
        {
            int n = 0;
            bool isCorrect = false;
            while (!isCorrect)
            {
                Console.Write("n = ");
                isCorrect = int.TryParse(Console.ReadLine(), out n);
                if (n <= 0)
                {
                    isCorrect = false;
                }
            }

            int[,] matrix = new int[n, n];
        }
    }
}
