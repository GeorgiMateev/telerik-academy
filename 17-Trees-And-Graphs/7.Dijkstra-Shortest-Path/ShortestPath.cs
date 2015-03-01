using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.Dijkstra_Shortest_Path
{
    class ShortestPath
    {
        const int verticesCount = 10;
        static uint[,] graph = new uint[,]
        {
            {0,23,0,0,0,0,0,8,0,0},
            {23,0,0,3,0,0,34,0,0,0},
            {0,0,0,6,0,0,0,25,0,7},
            {0,3,6,0,0,0,0,0,0,0},
            {0,0,0,0,0,10,0,0,0,0},
            {0,0,0,0,10,0,0,0,0,0},
            {0,34,0,0,0,0,0,0,0,0},
            {8,0,25,0,0,0,0,0,0,30},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,7,0,0,0,0,30,0,0},
        };

        static bool[] stillNotProceeded = new bool[verticesCount];
        static int[] currentMinValue = new int[verticesCount];
        static int[] predecessor = new int[verticesCount];

        static void Dijkstra(int startVertex)
        {
            for (int i = 0; i < verticesCount; i++)
            {
                if (graph[startVertex, i] == 0)
                {
                    currentMinValue[i] = int.MaxValue;
                    predecessor[i] = -1;
                }
                else
                {
                    currentMinValue[i] = (int)graph[startVertex, i];
                    predecessor[i] = startVertex;
                }
            }

            for (int i = 0; i < verticesCount; i++)
            {
                stillNotProceeded[i] = true;
            }
            stillNotProceeded[startVertex] = false;
            predecessor[startVertex] = -1;

            while (true)
            {
                int nextVertex = -1;
                int min = int.MaxValue;
                for (int i = 0; i < verticesCount; i++)
                {
                    if (stillNotProceeded[i] && currentMinValue[i]<min)
                    {
                        min = currentMinValue[i];
                        nextVertex = i;
                    }
                }

                if (nextVertex==-1)
                {
                    break;
                }
                stillNotProceeded[nextVertex] = false;

                for (int i = 0; i < verticesCount; i++)
                {
                    if (stillNotProceeded[i] && graph[nextVertex,i] != 0)
                    {
                        if (currentMinValue[nextVertex]+graph[nextVertex,i] < currentMinValue[i])
                        {
                            currentMinValue[i] = currentMinValue[nextVertex] + (int)graph[nextVertex, i];
                            predecessor[i] = nextVertex;
                        }
                    }
                }
            }
        }

        static void PrintPath(int start, int end)
        {
            Stack<int> vert = new Stack<int>();
            while (end != -1)
            {
                vert.Push(end);
                end = predecessor[end];
            }
            while (vert.Count>0)
            {
                Console.Write("{0} ",vert.Pop());
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int startVertex = 0;
            Dijkstra(startVertex);
            PrintPath(startVertex, 2);

            Console.ReadKey();
        }
    }
}
