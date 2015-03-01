using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17.KSubsetSum
{
    class KSubset
    {
        static int N;
        static int K;
        static int S;
        static int[] numbers;
        static int[] combination;
        static bool isFound;

        static void GetSubsetSum(int position,int index)
        {
            if (position==K)
            {
                CheckSum(); return;
            }
            if (isFound)
            {
                return;
            }
            for (int i = index; i < numbers.Length; i++)
            {               
                combination[position] = numbers[i];
                GetSubsetSum(position + 1,i+1);
            }
        }
        private static void CheckSum()
        {
            int s = 0;
            for (int i = 0; i < combination.Length; i++)
            {
                s += combination[i];
            }
            if (s == S)
            {
                isFound = true;
                Console.WriteLine();
                foreach (var item in combination)
                {
                    Console.Write("{0} ", item);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            bool isCorrectN = false;
            while (!isCorrectN)
            {
                Console.Write("N = ");
                isCorrectN = int.TryParse(Console.ReadLine(),out N);
            }
            numbers = new int[N];

            for (int i = 0; i < numbers.Length; i++)
            {
                int x = 0;
                bool isCorrectX = false;
                while (!isCorrectX)
                {
                    Console.Write("x = ");
                    isCorrectX = int.TryParse(Console.ReadLine(), out x);
                }
                numbers[i] = x;
            }
                        
            foreach (var item in numbers)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();

            isFound = false;

            bool isCorrectK = false;
            while (!isCorrectK)
            {
                Console.Write("K = ");
                isCorrectK = int.TryParse(Console.ReadLine(),out K);
            }

            bool isCorrectS = false;
            while (!isCorrectS)
            {
                Console.Write("S = ");
                isCorrectS = int.TryParse(Console.ReadLine(), out S);
            }

            combination = new int[K];

            GetSubsetSum(0,0);

            if (isFound)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            Console.ReadKey();
        }
    }
}
