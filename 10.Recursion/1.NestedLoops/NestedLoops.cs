using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _1.NestedLoops
{    
    class Nested_Loops
    {
        private static int[] vector;

        static void NestedLoops(int n,int k)
        {           
            if (n==0)
            {
                PrintVector(vector);               
                return;                
            }
            for (int i = 1; i <= k; i++)
            {
                vector[n-1] = i;
                NestedLoops(n - 1,k);
            }
        }

        private static void PrintVector(int[] vector)
        {
            for (int i = (vector.Length-1); i >= 0; i--)
            {
                Console.Write(vector[i]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            vector = new int[n];
            NestedLoops(n,n);

            Console.ReadKey();
        }
    }
}
