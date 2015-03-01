using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _3.ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            try
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine(content);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine(e.Message);
            }
          
            Console.ReadKey();
        }
    }
}
