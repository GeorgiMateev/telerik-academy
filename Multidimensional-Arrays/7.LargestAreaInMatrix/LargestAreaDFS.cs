using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.LargestAreaInMatrix
{
    struct Point
    {
        private int row;
        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        private int col;
        public int Col
        {
            get { return col; }
            set { col = value; }
        }

        public Point(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }

    class LargestAreaDFS
    {
        static List<Point> visited = new List<Point>();
        
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 6]
            {
                {1,3,2,2,2,4},
                {3,3,3,2,4,4},
                {4,3,1,2,3,3},
                {4,3,3,3,3,1},
                {4,3,3,3,1,1}
            };

            int maxCount = 0;

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (!visited.Contains(new Point(r,c)))
                    {
                        int count = CountDFS(matrix, r, c);
                        if (count>maxCount)
                        {
                            maxCount = count;
                        }
                    }
                }
            }

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write("{0} ",matrix[r,c]);
                }
                Console.WriteLine();
            }

            Console.Write("Largest area's size: {0}",maxCount);

            Console.ReadKey();
        }

        static private int CountDFS(int[,] matrix, int row, int col)
        {
            int counter = 1;
            int element = matrix[row,col];
            visited.Add(new Point(row, col));

            if (col+1<matrix.GetLength(1) && !visited.Contains(new Point(row,col+1)))
            {
                if (matrix[row, col + 1] == element)
                {
                    counter += CountDFS(matrix, row, col + 1);
                }
            }

            if (row+1 < matrix.GetLength(0) && !visited.Contains(new Point(row+1, col)))
            {
                if (matrix[row + 1, col] == element)
                {
                    counter += CountDFS(matrix, row + 1, col);
                }
            }

            if (col - 1 >= 0 && !visited.Contains(new Point(row, col - 1)))
            {
                if (matrix[row, col - 1] == element)
                {
                    counter += CountDFS(matrix, row, col - 1);
                }
            }

            if (row - 1 >= 0 && !visited.Contains(new Point(row - 1, col)))
            {
                if (matrix[row - 1, col] == element)
                {
                    counter += CountDFS(matrix, row - 1, col);
                }
            }

            return counter;
        }
    }
}
