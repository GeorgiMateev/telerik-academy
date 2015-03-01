using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21.Combinations
{
    class Combinations
    {
        private static int N;
        private static int K;
        private static int[] numbers;
        private static int[] combination;

        private static void Combination(int position,int index)
        {
            if (position == K)
            {
                ConsolePrintCombination(); return;
            }
            for (int i = index; i < numbers.Length; i++)
            {               
                combination[position] = numbers[i];
                Combination(position + 1,i+1);
            }
        }
        
        private static void ConsolePrintCombination()
        {
            foreach (var item in combination)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            bool isCorrectN = false;
            while (!isCorrectN)
            {
                Console.Write("N = ");
                isCorrectN = int.TryParse(Console.ReadLine(), out N);
            }

            numbers = new int[N];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
           
            bool isCorrectK = false;
            while (!isCorrectK)
            {
                Console.Write("K = ");
                isCorrectK = int.TryParse(Console.ReadLine(), out K);
            }

            combination = new int[K];
           
            Combination(0,0);


            Console.ReadKey();
        }
    }
}
