using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.ConnectedComponents
{
    class ConnectedComponents
    {
        static List<int>[] graph;
        static HashSet<int[]> components;
        static bool[] visitedVertices;

        private static int[] FindConnectedComponent(int startVertex)
        {
            Stack<int> componentVertices = new Stack<int>();
            FindConnectedComponentDFS(startVertex, componentVertices);
            return componentVertices.ToArray();
        }

        private static void FindConnectedComponentDFS(int startVertex, Stack<int> componentVertices)
        {
            componentVertices.Push(startVertex);
            visitedVertices[startVertex] = true;

            foreach (var vertex in graph[startVertex])
            {
                if (!visitedVertices[vertex])
                {
                    FindConnectedComponentDFS(vertex, componentVertices);
                }
            }
        }

        static void Main(string[] args)
        {
            graph = new List<int>[]
                {
                    new List<int>(new int[]{1,3}),
                    new List<int>(new int[]{0,2,6}),
                    new List<int>(new int[]{1,9,7,3}),
                    new List<int>(new int[]{0,2,7,10,4}),
                    new List<int>(new int[]{3}),
                    new List<int>(new int[]{6}),
                    new List<int>(new int[]{5,8}),
                    new List<int>(new int[]{2,3}),
                    new List<int>(new int[]{6}),
                    new List<int>(new int[]{2,10}),
                    new List<int>(new int[]{9,3}),

                    new List<int>(new int[]{12,13,14}),
                    new List<int>(new int[]{11,14}),
                    new List<int>(new int[]{11,14}),
                    new List<int>(new int[]{12,11,13}),

                    new List<int>(new int[]{15}),
                };
            components = new HashSet<int[]>();
            visitedVertices = new bool[graph.Length];

            for (int i = 0; i < visitedVertices.Length; i++)
            {
                if (!visitedVertices[i])
                {
                    components.Add(FindConnectedComponent(i));
                }
            }

            foreach (var component in components)
            {
                foreach (var vertex in component)
                {
                    Console.Write("{0} ",vertex);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }        
    }
}
