using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CalculateExpressions
{
    public class CalculateExpressions
    {
        public static double CalculateExpressionFromString(string str)
        {
            Queue<object> RPN = ConvertExpressionToRPN(str);
            double result = CalculateExpressionInRPN(RPN);
            return result;
        }

        /// <summary>
        /// Converts the given string expression to Reversed Polish Notation.
        /// </summary>
        /// <param name="str">The expression.</param>
        /// <returns></returns>
        public static Queue<object> ConvertExpressionToRPN(string s)
        {
            string str =  RemoveIntervalsInString(s);
            
            Stack<string> stack = new Stack<string>();
            Queue<object> queue = new Queue<object>();

            int index = 0;

            try
            {
                while (index < str.Length)
                {
                    char symbol = str[index];

                    bool isNumber = (int)symbol >= 48 && (int)symbol <= 57;
                    bool isLetter =
                        ((int)symbol >= 97 && (int)symbol <= 122) || ((int)symbol >= 65 && (int)symbol <= 90);
                    bool isOperator = symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/';


                    if (isNumber)
                    {
                        double number = GetNumber(str, ref index);
                        queue.Enqueue(number);
                    }

                    if (isLetter)
                    {
                        string function = GetFunction(str, ref index);
                        stack.Push(function);
                    }

                    if (symbol == ',')
                    {
                        ProceedWithComma(stack, queue);
                        index++;
                    }

                    if (isOperator)
                    {
                        if (symbol == '-')
                        {
                            bool isNumber2 = (int)str[index - 1] >= 48 && (int)str[index - 1] <= 57;
                            if (str[index - 1] == ')' || isNumber2)
                            {
                                ProceedWithOperator(stack, queue, symbol);
                                index++;
                            }
                            else
                            {
                                double number = GetNumber(str, ref index);
                                queue.Enqueue(number);
                            }
                        }
                        else
                        {
                            ProceedWithOperator(stack, queue, symbol);
                            index++;
                        }
                    }

                    if (symbol == '(')
                    {
                        stack.Push(symbol.ToString());
                        index++;
                    }

                    if (symbol == ')')
                    {
                        ProceedWithRightParenthesis(stack, queue);
                        index++;
                    }
                }
                TransferStackToQueue(stack, queue);
            }
            catch (IndexOutOfRangeException e)
            {
                throw new FormatException("The input expression is not in a correct format!", e);
            }

            return queue;
        }

        private static string RemoveIntervalsInString(string s)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]!=' ')
                {
                    str.Append(s[i]);
                }
            }
            return str.ToString();
        }

        private static void TransferStackToQueue(Stack<string> stack, Queue<object> queue)
        {
            while (stack.Count>0)
            {
                string item = stack.Pop();
                queue.Enqueue(item);
            }
        }

        private static void ProceedWithRightParenthesis(Stack<string> stack, Queue<object> queue)
        {
            while (stack.Peek() != '('.ToString())
            {
                string item = stack.Pop();
                queue.Enqueue(item);
                if (stack.Count==0)
                {
                    throw new FormatException("There are mismatched parentheses in the expression!");
                }
            }
            stack.Pop();
            if (stack.Count > 0)
            {
                bool isFunction =
                    ((int)stack.Peek()[0] >= 97 && (int)stack.Peek()[0] <= 122) || ((int)stack.Peek()[0] >= 65 && (int)stack.Peek()[0] <= 90);
                if (isFunction)
                {
                    string item = stack.Pop();
                    queue.Enqueue(item);
                }
            }
        }

        private static void ProceedWithOperator(Stack<string> stack, Queue<object> queue, char symbol)
        {
            if (stack.Count > 0)
            {
                bool isHigherPriority = symbol == '*' || symbol == '/';
                if (isHigherPriority)
                {
                    while (stack.Peek() == '*'.ToString() || stack.Peek() == '/'.ToString())
                    {
                        string item = stack.Pop();
                        queue.Enqueue(item);
                        if (stack.Count==0)
                        {
                            break;
                        }
                    }
                    stack.Push(symbol.ToString());
                }
                else
                {
                    while (stack.Peek() == '*'.ToString() || stack.Peek() == '/'.ToString() ||
                        stack.Peek() == '+'.ToString() || stack.Peek() == '-'.ToString())
                    {
                        string item = stack.Pop();
                        queue.Enqueue(item);
                        if (stack.Count==0)
                        {
                            break;
                        }
                    }
                    stack.Push(symbol.ToString());
                }
            }
            else
            {
                stack.Push(symbol.ToString());
            }
        }

        private static void ProceedWithComma(Stack<string> stack, Queue<object> queue)
        {
            while (stack.Peek() != ('(').ToString())
            {
                string item = stack.Pop();
                queue.Enqueue(item);
            }
            if (stack.Count==0)
            {
                throw new FormatException("There is misplaced function separator or mismatched parentheses in the expression!");
            }
        }

        /// <summary>
        /// Gets a function from a string at specified index and increases the index.
        /// </summary>
        /// <param name="str">The string. The function can be with small or capital letters.</param>
        /// <param name="index">Starting index.</param>
        /// <returns></returns>
        private static string GetFunction(string str, ref int index)
        {
            StringBuilder strFunct = new StringBuilder();
            char symbol = str[index];
            bool isLetter = false;
            do
            {
                strFunct.Append(symbol);
                index++;
                symbol = str[index];

                isLetter =
                    ((int)symbol >= 97 && (int)symbol <= 122) || ((int)symbol >= 65 && (int)symbol <= 90);
            }
            while (isLetter);
            return strFunct.ToString();
        }

        /// <summary>
        /// Gets a float point number from a string at specified index and increases the index.
        /// </summary>
        /// <param name="str">The string. The decimal point symbol should be '.' !</param>
        /// <param name="index">Starting index.</param>
        /// <returns></returns>
        private static double GetNumber(string str, ref int index)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture =
                System.Globalization.CultureInfo.CreateSpecificCulture("en-GB");

            StringBuilder strNumber = new StringBuilder();
            char symbol = str[index];

            bool isNumber = false;
            bool isDecimalPoint = false;

            do
            {                
                strNumber.Append(symbol);
                index++;
                if (index==str.Length)
                {
                    break;
                }
                symbol = str[index];

                isNumber = (int)symbol >= 48 && (int)symbol <= 57;
                isDecimalPoint = symbol == '.';
            } 
            while (isNumber||isDecimalPoint);

            string sNumber = strNumber.ToString();
            double number = 0;
            try
            {
                number = double.Parse(sNumber);
            }
            catch (FormatException e)
            {
                throw new FormatException("The input string is not correct formated!", e);
            }

            return number;
        }

        /// <summary>
        /// Calculates an expression given in Reversed Polish Notation
        /// </summary>
        /// <param name="queue"></param>
        /// <returns></returns>
        public static double CalculateExpressionInRPN(Queue<object> queue)
        {
            try
            {
                List<object> list = new List<object>();
                list = queue.ToList();

                int index = 0;
                while (list.Count > 1)
                {
                    string type = list[index].GetType().ToString();
                    if (type == "System.String")
                    {
                        string item = list[index].ToString();
                        switch (item[0])
                        {
                            case '+': OperatorAdd(list, ref index); break;
                            case '-': OperatorSubtract(list, ref index); break;
                            case '*': OperatorMulty(list, ref index); break;
                            case '/': OperatorDivide(list, ref index); break;
                            case 'L':
                            case 'l': FunctionLn(list, ref index); break;
                            case 'S':
                            case 's': FunctionSqrt(list, ref index); break;
                            case 'P':
                            case 'p': FunctionPow(list, ref index); break;

                            default:
                                break;
                        }
                    }
                    index++;
                }
                return (double)list[0];
            }
            catch (InvalidCastException e)
            {
                throw new FormatException("The input expression is not correct formated!", e);
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new FormatException("The input expression is not correct formated!", e);
            }
            catch (IndexOutOfRangeException e)
            {
                throw new FormatException("The input expression is not correct formated!", e);
            }
        }

        private static double FunctionPow(List<object> list, ref int index)
        {
            double result = Math.Pow((double)list[index - 2], (double)list[index - 1]);
            list[index] = result;
            list.RemoveAt(index - 1);
            list.RemoveAt(index - 2);
            index -= 2;
            return result;
        }

        private static double FunctionSqrt(List<object> list, ref int index)
        {
            double result = Math.Sqrt((double)list[index - 1]);
            list[index] = result;
            list.RemoveAt(index - 1);
            index -= 1;
            return result;
        }

        private static double FunctionLn(List<object> list, ref int index)
        {
            double result = Math.Log((double)list[index - 1]);
            list[index] = result;
            list.RemoveAt(index - 1);
            index -= 1;
            return result;
        }

        private static double OperatorDivide(List<object> list, ref int index)
        {
            double result = (double)list[index - 2] / (double)list[index - 1];
            list[index] = result;
            list.RemoveAt(index - 1);
            list.RemoveAt(index - 2);
            index -= 2;
            return result;
        }

        private static double OperatorMulty(List<object> list, ref int index)
        {
            double result = (double)list[index - 1] * (double)list[index - 2];
            list[index] = result;
            list.RemoveAt(index - 1);
            list.RemoveAt(index - 2);
            index -= 2;
            return result;
        }

        private static double OperatorSubtract(List<object> list, ref int index)
        {
            double result = (double)list[index - 2] - (double)list[index - 1];
            list[index] = result;
            list.RemoveAt(index - 1);
            list.RemoveAt(index - 2);
            index -= 2;
            return result;
        }

        private static double OperatorAdd(List<object> list, ref int index)
        {
            double result = (double)list[index - 1] + (double)list[index - 2];
            list[index] = result;
            list.RemoveAt(index - 1);
            list.RemoveAt(index - 2);
            index -= 2;
            return result;
        }        
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter expression (with only ln, pow and sqrt functions)");
            string input = Console.ReadLine();

            double result = 0;
            try
            {
                result = CalculateExpressions.CalculateExpressionFromString(input);
                Console.WriteLine("Result: {0}", result);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
    }
}
