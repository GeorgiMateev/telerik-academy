using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1D.Spiral
{
    class Spiral
    {
        static int n;
        static int[,] matrix;

        static int bottom;
        static int top;
        static int left;
        static int right;
        static int direction = 1; //1-bottom,2-right, 3-top, 4-left
        static int number = 1;
        static int row = -1;
        static int col = 0;

        static void Main(string[] args)
        {
            n = 0;
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

            matrix = new int[n, n];
            left = 0;
            right = matrix.GetLength(1);
            top = 0;
            bottom = matrix.GetLength(0);

            while (number<=n*n)
            {
                switch (direction)
                {
                    case 1: FillToBottom(); break;
                    case 2: FillToRight(); break;
                    case 3: FillToTop(); break;
                    case 4: FillToLeft(); break;
                    default:
                        break;
                }
            }

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write("{0} ", matrix[r, c]);
                }
                Console.WriteLine();
            }

           

            Console.ReadKey();
        }

        private static void FillToLeft()
        {
            col--;
            for (; col>left; col--)
            {
                matrix[row, col] = number;
                number++;
            }
            col++;
            left++;
            direction = 1;
        }

        private static void FillToTop()
        {
            row--;
            for (; row >= top; row--)
            {
                matrix[row, col] = number;
                number++;
            }
            row++;
            top++;
            direction = 4;
        }

        private static void FillToRight()
        {
            col++;
            for (; col < right; col++)
            {
                matrix[row, col] = number;
                number++;
            }
            col--;
            right--;
            direction = 3;
        }

        private static void FillToBottom()
        {
            row++;
            for (; row < bottom; row++)
            {
                matrix[row, col] = number;
                number++;
            }
            row--;
            bottom--;
            direction = 2;
        }
    }
}
