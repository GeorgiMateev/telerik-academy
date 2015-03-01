using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShortestPathInMatrix
{
    /// <summary>
    /// Contains the coordinates of a cell.
    /// </summary>
    public class Point
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

    class ShortestPathInMatrix
    {

        /// <summary>
        /// Scans the matrix with BFS algorythm until the end element is found.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="passableSymbol">The symbol that indicates whether a cell is passable.</param>
        /// <param name="start">The start element.</param>
        /// <param name="end">The final element.</param>
        /// <param name="isFound">Indicates whether the end element is found.</param>
        /// <returns>Returns matrix with ancestors.</returns>
        public static Point[,] BFS(char[,] matrix, char passableSymbol, Point start, Point end,out bool isFound)
        {
            Queue<Point> BFSQueue = new Queue<Point>();
            BFSQueue.Enqueue(start);

            Point[,] ancestorsMatrix = new Point[matrix.GetLength(0), matrix.GetLength(1)];
            ancestorsMatrix[start.Y, start.Y] = new Point(-1, -1);

            isFound = false;

            while (BFSQueue.Count > 0)
            {
                Point current = BFSQueue.Dequeue();             
                
                Point rightCell = new Point(current.X + 1, current.Y);
                bool isCorrectRightNeighbour = CheckForCorrectNeighbour(rightCell, matrix,passableSymbol,ancestorsMatrix);
                if (isCorrectRightNeighbour)
                {
                    BFSQueue.Enqueue(rightCell);
                    ancestorsMatrix[rightCell.Y,rightCell.X]=current;
                    if (rightCell.Equals(end))
                    {
                        isFound = true; break;
                    }
                }

                Point leftCell = new Point(current.X - 1, current.Y);
                bool isCorrectLeftNeighbour = CheckForCorrectNeighbour(leftCell, matrix,passableSymbol, ancestorsMatrix);
                if (isCorrectLeftNeighbour)
                {
                    BFSQueue.Enqueue(leftCell);
                    ancestorsMatrix[leftCell.Y, leftCell.X] = current;
                    if (leftCell.Equals(end))
                    {
                        isFound = true; break;
                    }
                }

                Point topCell = new Point(current.X, current.Y - 1);
                bool isCorrectTopNeighbour = CheckForCorrectNeighbour(topCell, matrix,passableSymbol,ancestorsMatrix);
                if (isCorrectTopNeighbour)
                {
                    BFSQueue.Enqueue(topCell);
                    ancestorsMatrix[topCell.Y, topCell.X] = current;
                    if (topCell.Equals(end))
                    {
                        isFound = true; break;
                    }
                }

                Point bottomCell = new Point(current.X, current.Y + 1);
                bool isCorrectBottomNeighbour = CheckForCorrectNeighbour(bottomCell, matrix,passableSymbol, ancestorsMatrix);
                if (isCorrectBottomNeighbour)
                {
                    BFSQueue.Enqueue(bottomCell);
                    ancestorsMatrix[bottomCell.Y, bottomCell.X] = current;
                    if (bottomCell.Equals(end))
                    {
                        isFound = true; break;
                    }
                }
            }

            return ancestorsMatrix;
        }

        /// <summary>
        /// Checks if given cell is in the matrix, is passable and is not visited.
        /// </summary>
        /// <param name="cell">Coordinates of a cell.</param>
        /// <param name="matrix">The matrix.</param>
        /// <param name="passSymbol">The symbol which indicates if a cell is passable.</param>
        /// <param name="visited">Set which contains the visited cells.</param>
        /// <returns></returns>
        private static bool CheckForCorrectNeighbour(Point cell, char[,] matrix, char passableSymbol, Point[,] visited)
        {
            bool isOutside = cell.X < 0 || cell.X >= matrix.GetLength(1)
                || cell.Y < 0 || cell.Y >= matrix.GetLength(0);
            if (isOutside)
            {
                return false;
            }
            bool isPassable = matrix[cell.Y, cell.X] == passableSymbol;
            bool isVisited = visited[cell.Y, cell.X] != null;
            if (!isVisited && isPassable)
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
                 {'*', '*', ' ', ' ', ' ', '*', ' '},
                 {' ', '*', ' ', '*', ' ', '*', 'm'},
                 {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            };

            bool isFound = false;
            Point start = new Point(1, 0);
            Point end = new Point(6, 2);
            Point[,] ancestrors = BFS(matrix, ' ',start ,end ,out isFound);

            Point[] path = new Point[0];
            if (isFound)
            {
                path = ExtractPath(ancestrors, start, end);
                Console.WriteLine("The path is marked with \"*\".");
                foreach (var item in path)
                {
                    Console.CursorTop = item.Y + 2;
                    Console.CursorLeft = item.X;
                    Console.Write('*');
                }
            }
            else
            {
                Console.WriteLine("There is no path!");
            }            

            Console.ReadKey();
        }

        /// <summary>
        /// Gets the path between two elements in given ancestors matrix.
        /// </summary>
        /// <param name="ancestrors">The ancestors matrix.</param>
        /// <param name="start">The first element of the path.</param>
        /// <param name="end">The last elemnt in the path.</param>
        /// <returns></returns>
        private static Point[] ExtractPath(Point[,] ancestrorsMatrix, Point start, Point end)
        {
            if (ancestrorsMatrix[end.Y,end.X]==null)
            {
                throw new ArgumentException("The final element doesn't have ancestor!");
            }

            Stack<Point> stack = new Stack<Point>();

            Point current = end;
            stack.Push(current);
            while (!(start.Equals(current)))
            {
                current = ancestrorsMatrix[current.Y, current.X];
                stack.Push(current);
            }

            Point[] path = new Point[stack.Count];
            int count = stack.Count;
            for (int i = 0; i < count; i++)
            {
                path[i] = stack.Pop();
            }

            return path;
        }
    }
}
