using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1A.IncreasingNumbers_To_Down
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            bool isCorrect = false;
            while (!isCorrect)
            {
                Console.Write("n = ");
                isCorrect = int.TryParse(Console.ReadLine(), out n);
                if (n<=0)
                {
                    isCorrect = false;
                }
            }

            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row,0] = row + 1;
                Console.Write("{0} ", matrix[row, 0]);
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrix[row, col - 1] + n;
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
