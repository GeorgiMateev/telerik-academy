using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace _18.Labyrinth
{
    struct Point
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
            Point objP = (Point)obj;
            if (this.x==objP.x && this.y==objP.y)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            int prime = 83;
            int result = 1;
            result = result * prime + this.x;
            result = result * prime + this.y;
            return result;
        }
    }

    class PointComparer : IEqualityComparer<Point>
    {
        public bool Equals(Point p1, Point p2)
        {
            if (p1.X==p2.X && p1.Y==p2.Y)
            {
                return true;
            }
            return false;
        }

        public int GetHashCode(Point obj)
        {
            return obj.GetHashCode();
        }
    }

    class Labyrinth
    {
        static int N;
        static int[,] labyrinth;
        static Point Beginning;

        static void Main(string[] args)
        {
            //Input format with N = 4
            //0 0 X 0
            //X 0 * X
            //X X 0 X
            //0 0 0 0
            

            N = int.Parse(Console.ReadLine());
            labyrinth = new int[N, N];
            for (int row = 0; row < N; row++)
            {
                string line = Console.ReadLine();
                string[] lineParts = line.Split(' ');

                for (int col = 0; col < lineParts.Length; col++)
                {
                    //If the char is X puts -1 in the labyrinth
                    //If the char is * puts -2 in the labyrinth
                    char current = Char.Parse(lineParts[col]);
                    if (!Char.IsDigit(current))
                    {
                        if (!Char.IsLetter(current))
                        {
                            Beginning = new Point(col, row);
                            labyrinth[row, col] = -2;
                        }
                        else
                        {
                            labyrinth[row, col] = -1;
                        }
                    }
                    else
                    {
                        labyrinth[row, col] = int.Parse(lineParts[col]);
                    }
                }
            }

            Stopwatch timer = new Stopwatch();
            timer.Start();

            BFSTraverse();

            timer.Stop();

            Console.WriteLine("Time elapsed: {0}",timer.ElapsedMilliseconds);

            //StreamWriter resultInFile = new StreamWriter("result.txt", false);
            //using (resultInFile)
            //{
            //    for (int row = 0; row < N; row++)
            //    {
            //        for (int col = 0; col < N; col++)
            //        {
            //            int currentValue = labyrinth[row, col];
            //            if (currentValue >= 1)
            //            {
            //                //Console.Write("{0} ", currentValue);
            //                resultInFile.Write("{0} ", currentValue);
            //            }
            //            else
            //            {
            //                if (currentValue == 0)
            //                {
            //                    //Console.Write("u ");
            //                    resultInFile.Write("u ");
            //                }
            //                if (currentValue == -2)
            //                {
            //                    //Console.Write("* ");
            //                    resultInFile.Write("* ");
            //                }
            //                if (currentValue == -1)
            //                {
            //                    //Console.Write("x ");
            //                    resultInFile.Write("x ");
            //                }
            //            }
            //        }
            //        resultInFile.WriteLine();
            //    }
            //}
        }

        static void BFSTraverse()
        {
            Queue<Point> BFSQueue = new Queue<Point>();
            HashSet<Point> visited = new HashSet<Point>();
            BFSQueue.Enqueue(Beginning);
            visited.Add(Beginning);

            while (BFSQueue.Count>0)
            {
                Point currentPoint = BFSQueue.Dequeue();
                int nextValue = 0;
                int currentValue = labyrinth[currentPoint.Y,currentPoint.X];
                if (currentValue!=-2)
                {
                    nextValue = currentValue + 1;
                }
                else
                {
                    nextValue = 1;
                }

                bool correctRight =
                    !visited.Contains(new Point(currentPoint.X + 1, currentPoint.Y)) &&
                    currentPoint.X + 1 < labyrinth.GetLength(1) &&
                    labyrinth[currentPoint.Y, currentPoint.X + 1] != -1;
                if (correctRight)
                {
                    labyrinth[currentPoint.Y, currentPoint.X+1] = nextValue;
                    BFSQueue.Enqueue(new Point(currentPoint.X+1,currentPoint.Y));
                    visited.Add(new Point(currentPoint.X + 1, currentPoint.Y));
                }

                bool correctLeft =
                    !visited.Contains(new Point(currentPoint.X - 1, currentPoint.Y)) &&
                    currentPoint.X-1>=0 &&
                    labyrinth[currentPoint.Y,currentPoint.X-1]!=-1;
                if (correctLeft)
                {
                    labyrinth[currentPoint.Y, currentPoint.X-1] = nextValue;
                    BFSQueue.Enqueue(new Point(currentPoint.X-1,currentPoint.Y));
                    visited.Add(new Point(currentPoint.X-1,currentPoint.Y));
                }

                bool correctTop =
                    !visited.Contains(new Point(currentPoint.X, currentPoint.Y-1)) &&
                    currentPoint.Y-1>=0 &&
                    labyrinth[currentPoint.Y-1,currentPoint.X]!=-1;
                if (correctTop)
                {
                    labyrinth[currentPoint.Y-1, currentPoint.X] = nextValue;
                    BFSQueue.Enqueue(new Point(currentPoint.X,currentPoint.Y-1));
                    visited.Add(new Point(currentPoint.X, currentPoint.Y-1));
                }

                bool correctBottom =
                    !visited.Contains(new Point(currentPoint.X, currentPoint.Y + 1)) &&
                    currentPoint.Y + 1 <labyrinth.GetLength(0) &&
                    labyrinth[currentPoint.Y + 1, currentPoint.X] != -1;
                if (correctBottom)
                {
                    labyrinth[currentPoint.Y + 1, currentPoint.X] = nextValue;
                    BFSQueue.Enqueue(new Point(currentPoint.X, currentPoint.Y + 1));
                    visited.Add(new Point(currentPoint.X,currentPoint.Y+1));
                }
            }
        }
    }
}
