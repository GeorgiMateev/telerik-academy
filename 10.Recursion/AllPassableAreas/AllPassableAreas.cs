using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllPassableAreas
{
    /// <summary>
    /// Contains the coordinates of a cell.
    /// </summary>
    public struct Point
    {
        private int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        
        public override bool Equals(object obj)
        {
            if (this.X == ((Point)obj).X && this.Y == ((Point)obj).Y)
            {
                return true;
            }
            return false;
        }
    }

    class AllPassableAreas
    {

        /// <summary>
        /// Finds all passable areas.
        /// </summary>
        /// <param name="matrix">The matrix in which to search.</param>
        /// <param name="passableArea">The set where to store coordinates.</param>
        /// <param name="passSymbol">"The symbol which indicates if one cell is passable."</param>
        static void FindAllPassableAreas(char[,] matrix, HashSet<Point> passableArea, char passSymbol)
        {
            if (passableArea==null)
            {
                throw new ArgumentNullException("The given set can not be empty!");
            }

            Point startPoint = new Point(-1,-1);

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r,c] == passSymbol)
                    {
                        startPoint = new Point(c, r); goto endCycle;
                    }
                }
            }
            endCycle:

            if (startPoint.X==-1 && startPoint.Y==-1)
            {
                return;
            }

            Queue<Point> BFSQueue = new Queue<Point>();
            BFSQueue.Enqueue(startPoint);            

            HashSet<Point> visited = new HashSet<Point>();
            visited.Add(startPoint);

            while (BFSQueue.Count>0)
            {
                Point current = BFSQueue.Dequeue();
                if (matrix[current.Y,current.X] == ' ')
                {
                    passableArea.Add(current);
                }                

                Point rightCell = new Point(current.X + 1, current.Y);
                bool isCorrectRightNeighbour = CheckForCorrectNeighbour(rightCell, matrix, visited);
                if (isCorrectRightNeighbour)
                {
                    BFSQueue.Enqueue(rightCell);
                    visited.Add(rightCell);
                }

                Point leftCell = new Point(current.X - 1, current.Y);
                bool isCorrectLeftNeighbour = CheckForCorrectNeighbour(leftCell, matrix, visited);
                if (isCorrectLeftNeighbour)
                {
                    BFSQueue.Enqueue(leftCell);
                    visited.Add(leftCell);
                }

                Point topCell = new Point(current.X, current.Y - 1);
                bool isCorrectTopNeighbour = CheckForCorrectNeighbour(topCell, matrix, visited);
                if (isCorrectTopNeighbour)
                {
                    BFSQueue.Enqueue(topCell);
                    visited.Add(topCell);
                }

                Point bottomCell = new Point(current.X, current.Y + 1);
                bool isCorrectBottomNeighbour = CheckForCorrectNeighbour(bottomCell, matrix, visited);
                if (isCorrectBottomNeighbour)
                {
                    BFSQueue.Enqueue(bottomCell);
                    visited.Add(bottomCell);
                }
            }

        }

        /// <summary>
        /// Checks if given cell is in the matrix, is passable and is not visited.
        /// </summary>
        /// <param name="cell">Coordinates of a cell.</param>
        /// <param name="matrix">The matrix.</param>
        /// <param name="passSymbol">The symbol which indicates if a cell is passable.</param>
        /// <param name="visited">Set which contains the visited cells.</param>
        /// <returns></returns>
        private static bool CheckForCorrectNeighbour(Point cell, char[,] matrix, HashSet<Point> visited)
        {
            bool isOutside = cell.X < 0 || cell.X >= matrix.GetLength(1)
                || cell.Y < 0 || cell.Y >= matrix.GetLength(0);
            if (isOutside)
            {
                return false;
            }

            bool isVisited = visited.Contains(cell);
            if (!isVisited)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            char[,] matrix = new char[,]
            {
                 {' ', ' ', '*', '*', ' ', ' ', ' '},
                 {' ', ' ', ' ', '*', ' ', '*', ' '},
                 {'*', '*', ' ', '*', '*', ' ', ' '},
                 {' ', '*', '*', '*', '*', '*', 'm'},
                 {' ', ' ', '*', '*', ' ', ' ', ' '},
            };

            HashSet<Point> passableArea = new HashSet<Point>();
            AllPassableAreas.FindAllPassableAreas(matrix, passableArea, ' ');

            Console.WriteLine("The passable areas are marked with \"*\".");
            foreach (var item in passableArea)
            {
                Console.CursorLeft = item.X;
                Console.CursorTop = item.Y + 1;
                Console.Write('*');

            }

            Console.ReadKey();
        }
    }
}
