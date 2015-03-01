using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cycles
{
    public static class Cycles
    {
        struct Edge
        {
            private int v1;
            public int V1
            {
                get { return v1; }
                set { v1 = value; }
            }

            private int v2;
            public int V2
            {
                get { return v2; }
                set { v2 = value; }
            }

            public Edge(int v1, int v2)
            {
                this.v1 = v1;
                this.v2 = v2;
            }           
        }

        public static List<int>[] graph = new List<int>[]{};
        public static List<int>[] Graph
        {
            get { return Cycles.graph; }
            set { Cycles.graph = value; }
        }

        private static int[] CreateCoverTree()
        {
            int[] coverTree = new int[graph.Length];
            bool[] visitedVerteces = new bool[graph.Length];

            CreateCoverTreeDFS(-1,0, coverTree, visitedVerteces);

            return coverTree;
        }

        private static void CreateCoverTreeDFS(int ancestor, int vertex, int[] coverTree, bool[] visitedVerteces)
        {
            coverTree[vertex] = ancestor;
            visitedVerteces[vertex] = true;

            foreach (var item in graph[vertex])
            {
                if (!visitedVerteces[item])
                {
                    CreateCoverTreeDFS(vertex, item, coverTree, visitedVerteces);
                }
            }
        }

        private static HashSet<Edge> FindUnusedEdges(int[] coverTree)
        {
            HashSet<Edge> unused = new HashSet<Edge>();
            for (int vertex = 0; vertex < graph.Length; vertex++)
            {
                for (int i = 0; i < graph[vertex].Count; i++)
                {
                    int neighbour = graph[vertex][i];
                    if (coverTree[vertex]!=neighbour && coverTree[neighbour]!=vertex && !unused.Contains(new Edge(neighbour,vertex)))
                    {
                        unused.Add(new Edge(vertex, neighbour));
                    }
                }
            }
            return unused;
        }


        private static Stack<int> cycle = new Stack<int>();
        private static bool[] visited;

        private static void FindCycleDFS(int startV, int endV)
        {
            cycle.Push(startV);
            visited[startV] = true;

            if (startV==endV)
            {
                if (cycle.Count >= 3)
                {
                    PrintCycle();
                }
                visited[startV] = false;
                cycle.Pop();
                return;
            }
            
            foreach (var vertex in graph[startV])
            {
                if (!visited[vertex])
                {
                    FindCycleDFS(vertex, endV);
                }
            }

            visited[startV] = false;
            cycle.Pop();
        }
                
        public static void PrintAllCyclesInGraph()
        {
            int[] graphCoverTree = CreateCoverTree();
            HashSet<Edge> unused = FindUnusedEdges(graphCoverTree);

            visited = new bool[Graph.Length];
            foreach (var edge in unused)
            {
                FindCycleDFS(edge.V1, edge.V2);
                RemoveEdge(edge.V1, edge.V2);
            }
        }

        private static void RemoveEdge(int v1, int v2)
        {
            graph[v1].Remove(v2);
            graph[v2].Remove(v1);
        }

        private static void PrintCycle()
        {
            int[] c = cycle.ToArray();
            for (int i = c.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", c[i]);
            }
            Console.WriteLine();
        }
    }
}
