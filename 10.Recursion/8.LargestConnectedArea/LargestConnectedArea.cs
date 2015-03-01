using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.LargestConnectedArea
{
    public struct Cell
    {
        private int x;
        private int y;

        public int X
        { 
            get 
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class LargestConnectedArea
    {
        static char[,] matrix = new char[,]
            {
                 {' ', ' ', '*', '*', ' ', ' ', ' '},
                 {' ', ' ', ' ', '*', ' ', '*', ' '},
                 {' ', '*', ' ', '*', '*', ' ', ' '},
                 {' ', '*', '*', '*', '*', '*', ' '},
                 {' ', ' ', '*', '*', ' ', ' ', ' '},
            };

        static HashSet<Cell> largestEmptyArea = new HashSet<Cell>();

        public static void FindLargestConnectedEmptyAreaBFS(Cell startCell, HashSet<Cell> emptyArea)
        {
            emptyArea.Clear();

            Queue<Cell> BFSQueue = new Queue<Cell>();
            BFSQueue.Enqueue(startCell);

            while (BFSQueue.Count>0)
            {
                Cell currentCell = BFSQueue.Dequeue();

                emptyArea.Add(currentCell);
                matrix[currentCell.Y, currentCell.X] = 'm';

                bool isProperRightNeighbour = CheckNeighbour(currentCell.X + 1, currentCell.Y, emptyArea);
                if (isProperRightNeighbour)
                {
                    BFSQueue.Enqueue(new Cell(currentCell.X + 1, currentCell.Y));
                }

                bool isProperBottomNeighbour = CheckNeighbour(currentCell.X, currentCell.Y+1, emptyArea);
                if (isProperBottomNeighbour)
                {
                    BFSQueue.Enqueue(new Cell(currentCell.X, currentCell.Y+1));
                }

                bool isProperLeftNeighbour = CheckNeighbour(currentCell.X - 1, currentCell.Y, emptyArea);
                if (isProperLeftNeighbour)
                {
                    BFSQueue.Enqueue(new Cell(currentCell.X - 1, currentCell.Y));
                }

                bool isProperTopNeighbour = CheckNeighbour(currentCell.X, currentCell.Y - 1, emptyArea);
                if (isProperTopNeighbour)
                {
                    BFSQueue.Enqueue(new Cell(currentCell.X, currentCell.Y - 1));
                }

            }
        }

        private static bool CheckNeighbour(int x, int y, HashSet<Cell> emptyArea)
        {
            bool isInside = x >= 0 && x < matrix.GetLength(1) && y >= 0 && y < matrix.GetLength(0);
            if (!isInside)
            {
                return false;
            }

            bool isEmpty = matrix[y, x] == ' ';
            bool isEncircling = emptyArea.Contains(new Cell(x, y));

            if (isEmpty && !isEncircling)
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
           
            HashSet<Cell> currentArea = new HashSet<Cell>();

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r,c] != '*' && matrix[r,c] != 'm')
                    {
                        FindLargestConnectedEmptyAreaBFS(new Cell(c, r), currentArea);
                        if (currentArea.Count > largestEmptyArea.Count)
                        {
                            largestEmptyArea.Clear();
                            largestEmptyArea.UnionWith(currentArea);
                        }
                    }
                }
            }

            Console.WriteLine("The largest empty area is painted with *");
            foreach (var item in largestEmptyArea)
            {
                Console.CursorLeft = item.X;
                Console.CursorTop = item.Y + 5;
                Console.Write('*');
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
