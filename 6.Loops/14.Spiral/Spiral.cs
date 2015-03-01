using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14.Spiral
{
    class Spiral
    {
        static void Main(string[] args)
        {
            byte n;
            while (true)
            {
                try
                {
                    Console.Write("N = ");
                    n = byte.Parse(Console.ReadLine());
                    if (n <= 0 || n >= 20)
                    {
                        throw new ArgumentOutOfRangeException("Enter only integer number between 1 and 19 !");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only integer number between 1 and 19!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Enter smaller integer number!");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Enter integer number between 1 and 19");
                }
            }

            

            int[,] matrix = new int[19, 19];

            byte direction = 2;   //1-up; 2-right; 3-down; 4-left

            byte rightBorder = n;
            sbyte leftBorder = -1;
            sbyte upBorder = 0;
            byte downBorder = n;

            byte currentRow = 0;
            byte currentCol = 0;

            matrix[0, 0] = 1;

            bool isStreight = true;

            for (int i = 2; i <= n*n; i++)
            {
                do
                {
                    switch (direction)
                    {

                        case 1:
                            if (currentRow-1 != upBorder && currentRow-1 >= 0)
                            {
                                matrix[currentRow-1, currentCol] = i;
                                currentRow--;
                                isStreight = true;
                            }
                            else
                            {
                                upBorder++;
                                direction = 2;
                                isStreight = false;
                            } break;

                        case 2:
                            if (currentCol+1 != rightBorder && currentCol+1<n)
                            {
                                matrix[currentRow, currentCol+1] = i;
                                currentCol++;
                                isStreight = true;
                            }
                            else
                            {
                                rightBorder--;
                                direction = 3;
                                isStreight = false;
                            } break;

                        case 3:
                            if (currentRow+1 != downBorder && currentRow+1 < n)
                            {
                                matrix[currentRow+1, currentCol] = i;
                                currentRow++;
                                isStreight = true;
                            }
                            else
                            {
                                downBorder--;
                                direction = 4;
                                isStreight = false;
                            } break;

                        case 4:
                            if (currentCol-1 != leftBorder && currentCol-1 >= 0)
                            {
                                matrix[currentRow, currentCol-1] = i;
                                currentCol--;
                                isStreight = true;
                            }
                            else
                            {
                                leftBorder++;
                                direction = 1;
                                isStreight = false;
                            } break;
                     }
                } 
                while (!isStreight);
            }

            Console.WriteLine();

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row,col]<10)
                    {
                        Console.Write("{0}   ", matrix[row, col]);
                    }
                    if (matrix[row,col]<100 && matrix[row,col]>9)
                    {
                        Console.Write("{0}  ", matrix[row, col]);
                    }
                    if (matrix[row,col]>99)
                    {
                        Console.Write("{0} ", matrix[row, col]);
                    }
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}
