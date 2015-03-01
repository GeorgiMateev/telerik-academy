using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8.ChooseType
{
    class ChooseType
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int intInput = 0;
            double doubleInput = 0;
            
            if (int.TryParse(input,out intInput))
            {
                Console.WriteLine(intInput+1);
            }
            else if(double.TryParse(input,out doubleInput))
            {
                Console.WriteLine(doubleInput+1);
            }
            else
            {
                Console.WriteLine(input+'*');
            }

            Console.ReadKey(true);
           
        }
    }
}
