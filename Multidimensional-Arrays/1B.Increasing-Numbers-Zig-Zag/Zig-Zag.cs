using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1B.Increasing_Numbers_Zig_Zag
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
                if (n <= 0)
                {
                    isCorrect = false;
                }
            }

            int[,] matrix = new int[n, n];

            int number = n;
            int col = 0;
            int direction = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = row + 1;
            }
            col++;
            direction = 1;
            while (col < matrix.GetLength(1))
            {
                if (direction == 1)
                {
                    number += n;
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = number;
                        number--;
                    }
                    number += n;
                    number++;
                    direction = 0;
                }
                else
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, col] = number;
                        number++;
                    }
                    number--;
                    direction = 1;
                }
                col++;
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.Write("{0} ",matrix[row,cols]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
