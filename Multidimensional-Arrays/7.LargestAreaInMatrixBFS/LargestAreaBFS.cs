using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.LargestAreaInMatrixBFS
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

    class LargestAreaBFS
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
                    int count = CountBFS(matrix, r, c);
                    if (count>maxCount)
                    {
                        maxCount = count;
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

            Console.Write("Largest area's size: {0}", maxCount);

            Console.ReadKey();
        }

        static int CountBFS(int[,] matrix, int row, int col)
        {
            Queue<Point> queue = new Queue<Point>();
            queue.Enqueue(new Point(row,col));
            visited.Add(new Point(row, col));
            int counter = 0;
            int number = matrix[row,col];

            while (queue.Count>0)
            {
                Point current = queue.Dequeue();
                counter++;

                if (current.Col+1<matrix.GetLength(1) && !visited.Contains(new Point(current.Row,current.Col+1)))
                {
                    if (matrix[current.Row,current.Col+1] == number)
                    {
                        queue.Enqueue(new Point(current.Row, current.Col + 1));
                        visited.Add(new Point(current.Row, current.Col + 1));
                    }
                }

                if (current.Row + 1 < matrix.GetLength(0) && !visited.Contains(new Point(current.Row+1, current.Col)))
                {
                    if (matrix[current.Row+1, current.Col] == number)
                    {
                        queue.Enqueue(new Point(current.Row + 1, current.Col));
                        visited.Add(new Point(current.Row + 1, current.Col));
                    }
                }

                if (current.Col - 1 >= 0 && !visited.Contains(new Point(current.Row, current.Col - 1)))
                {
                    if (matrix[current.Row, current.Col - 1] == number)
                    {
                        queue.Enqueue(new Point(current.Row, current.Col - 1));
                        visited.Add(new Point(current.Row, current.Col - 1));
                    }
                }

                if (current.Row - 1 >=0 && !visited.Contains(new Point(current.Row - 1, current.Col)))
                {
                    if (matrix[current.Row - 1, current.Col] == number)
                    {
                        queue.Enqueue(new Point(current.Row - 1, current.Col));
                        visited.Add(new Point(current.Row - 1, current.Col));
                    }
                }
            }

            return counter;
        }
    }
}
