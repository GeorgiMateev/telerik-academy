using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.FillRestOfTheString
{
    class FillRestOfTheString
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int difference = 20 - str.Length;

            if (difference>0)
            {
                string addition = new string('*', difference);
                string completed = String.Concat(str,addition);
                Console.WriteLine(completed);
            }
            if (difference<0)
            {
                Console.WriteLine("The string should be less than 20 symbols.");
            }
            if (difference==0)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
