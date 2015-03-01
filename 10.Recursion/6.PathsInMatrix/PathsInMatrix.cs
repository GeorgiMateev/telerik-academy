using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.PathsInMatrix
{
    class PathsInMatrix
    {
        static char[,] matrix = new char[,]
        {
             {' ', ' ', ' ', '*', ' ', ' ', ' '},
             {' ', '*', ' ', '*', ' ', '*', ' '},
             {' ', ' ', ' ', ' ', ' ', ' ', ' '},
             {' ', '*', '*', '*', '*', '*', ' '},
             {' ', ' ', ' ', ' ', ' ', ' ', ' '},
        };
        static Stack<char> path = new Stack<char>();
        static bool PathIsFound = false;

        static void DFSCellToCell(int startX, int startY, int endX, int endY, char direction)
        {
            if (startX<0 || startX>=matrix.GetLength(1) || startY<0 ||startY>=matrix.GetLength(0))
            {
                return;
            }

            path.Push(direction);

            if (matrix[startY,startX] != ' ')
            {
                path.Pop(); return;
            }

            if (startX==endX && startY==endY)
            {
                PathIsFound = true;
                PrintPath();
                path.Pop();
                return;
            }
            
            matrix[startY,startX] = direction;

            DFSCellToCell(startX + 1, startY, endX, endY, 'R');
            DFSCellToCell(startX, startY+1, endX, endY, 'D');
            DFSCellToCell(startX - 1, startY, endX, endY, 'L');
            DFSCellToCell(startX, startY-1, endX, endY, 'U');

            path.Pop();
            matrix[startY, startX] = ' ';
        }

        private static void PrintPath()
        {

            for (int i = path.Count-1; i >= 0; i--)
            {
                Console.Write(path.ElementAt(i));
            }
            Console.WriteLine();
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

            DFSCellToCell(sX, sY, eX, eY, 'S');

            if (!PathIsFound)
            {
                Console.WriteLine("There is no path!");
            }

            Console.ReadKey();
        }
    }
}
