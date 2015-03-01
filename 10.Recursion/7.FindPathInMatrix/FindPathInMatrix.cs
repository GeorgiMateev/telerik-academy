using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.FindPathInMatrix
{
    class FindPathInMatrix
    {
        static char[,] matrix = new char[,]
        {
             {' ', ' ', ' ', '*', ' ', ' ', ' '},
             {' ', '*', ' ', '*', ' ', '*', ' '},
             {' ', ' ', ' ', ' ', ' ', ' ', ' '},
             {' ', '*', '*', '*', '*', '*', ' '},
             {' ', ' ', ' ', ' ', ' ', ' ', ' '},
        };

        static bool PathIsFound = false;

        public static void DFSPath(int startX, int startY, int endX, int endY, ref bool isFound)
        {
            if (isFound)
            {
                return;
            }

            if (startX < 0 || startX >= matrix.GetLength(1) || startY < 0 || startY >= matrix.GetLength(0))
            {
                return;
            }

            if (matrix[startY, startX] != ' ')
            {
                return;
            }

            if (startX == endX && startY == endY)
            {
                isFound = true;
                return;
            }

            matrix[startY, startX] = '*';

            DFSPath(startX + 1, startY, endX, endY, ref isFound);
            DFSPath(startX, startY + 1, endX, endY, ref isFound);
            DFSPath(startX - 1, startY, endX, endY, ref isFound);
            DFSPath(startX, startY - 1, endX, endY, ref isFound);

            matrix[startY, startX] = ' ';
        }

        static void Main(string[] args)
        {
            Console.Write("Start X = ");
            int sX = int.Parse(Console.ReadLine());

            Console.Write("Start Y = ");
            int sY = int.Parse(Console.ReadLine());

            Console.Write("End X = ");
            int eX = int.Parse(Console.ReadLine());

            Console.Write("End Y = ");
            int eY = int.Parse(Console.ReadLine());

            DFSPath(sX, sY, eX, eY, ref PathIsFound);

            if (!PathIsFound)
            {
                Console.WriteLine("There is no path!");
            }
            else
            {
                Console.WriteLine("There is path!");
            }

            Console.ReadKey();
        }
    }
}
