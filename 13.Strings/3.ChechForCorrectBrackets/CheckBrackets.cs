using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3.ChechForCorrectBrackets
{
    class CheckBrackets
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            bool isCorrect = CheckCorrectBrackets(expression);

            if (isCorrect)
            {
                Console.WriteLine("The expression is correct!");
            }
            else
            {
                Console.WriteLine("The expression is wrong!");
            }

            Console.ReadKey();
        }

        private static bool CheckCorrectBrackets(string expression)
        {
            bool isCorrect = true;

            int openBrackets = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    openBrackets++;
                }

                if (expression[i] == ')')
                {
                    if (openBrackets == 0)
                    {
                        isCorrect = false; break;
                    }
                    else
                    {
                        openBrackets--;
                    }
                }
            }
            if (openBrackets > 0)
            {
                isCorrect = false;
            }
            return isCorrect;
        }
    }
}
