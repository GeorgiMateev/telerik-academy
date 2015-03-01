using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.MaxSumInSquare
{
    class MaxSumInSquare
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

            int m = 0;
            bool isCorrectM = false;
            while (!isCorrectM)
            {
                Console.Write("m = ");
                isCorrectM = int.TryParse(Console.ReadLine(), out m);
                if (m <= 0)
                {
                    isCorrect = false;
                }
            }

            int[,] matrix = new int[n,m];
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    int x = 0;
                    bool isCorrectX = false;
                    while (!isCorrectX)
                    {
                        Console.Write("x = ");
                        isCorrectX = int.TryParse(Console.ReadLine(), out x);
                        matrix[r, c] = x;
                    }
                }
                Console.WriteLine();
            }
            //{
            //    {1,8,6,-1,15,-20,-100},
            //    {18,5,-4,-6,2,3,8},
            //    {-2,-13,-15,0,17,-4,30},
            //    {-6,21,8,9,-10,-5,1},
            //    {8,6,1,0,3,-7,-5}
            //};

            int maxSum = 0;
            int maxSumRow = 0;
            int maxSumCol = 0;

            for (int row = 0; row <= matrix.GetLength(0)-3; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1)-3; col++)
                {
                    int sum = GetSum(matrix, row, col);
                    if (sum>maxSum)
                    {
                        maxSum = sum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Max sum = {0}",maxSum);
            for (int r = maxSumRow; r <= maxSumRow+2; r++)
            {
                for (int c = maxSumCol; c <= maxSumCol+2; c++)
                {
                    Console.Write("{0} ",matrix[r,c]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static int GetSum(int[,] matrix, int row, int col)
        {
            int sum = 0;
            for (int r = row; r <= row+2; r++)
            {
                for (int c = col; c <= col+2; c++)
                {
                    sum += matrix[r, c];
                }
            }
            return sum;
        }
    }
}
