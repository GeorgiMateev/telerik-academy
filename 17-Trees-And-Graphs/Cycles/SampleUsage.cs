using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cycles
{
    class SampleUsage
    {
        static void Main(string[] args)
        {
            Cycles.graph = new List<int>[]
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
                };

            Cycles.PrintAllCyclesInGraph();

            Console.ReadKey();
        }
    }
}
