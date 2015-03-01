using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5.StringCombinations
{
    class StringCombiantions
    {
        static string[] stringSet;
        static int[] combination;
        delegate void PrintStringCombinationDel(int[] combination);

        static void GenerateCombination(int length, int range, int index, Delegate proceedCombination )
        {
            if (length==0)
            {
                proceedCombination.DynamicInvoke(combination); return;
            }
            for (int i = index+1; i < range; i++)
            {
                combination[length - 1] = i;
                GenerateCombination(length - 1, range, i, proceedCombination);
            }
        }

        public static void PrintStringCombination(int[] combination)
        {
            for (int i = 0; i < combination.Length; i++)
            {
                Console.Write("{0} ",stringSet[combination[i]]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            stringSet = new string[] {"Georgi","Ico","Anna","Misho","Gesho","Monika","Boris" };
            int k = int.Parse(Console.ReadLine());
            combination = new int[k];

            PrintStringCombinationDel printStrings = PrintStringCombination;

            GenerateCombination(k, stringSet.Length, -1, printStrings);
            
            Console.ReadKey();
        }
    }
}
