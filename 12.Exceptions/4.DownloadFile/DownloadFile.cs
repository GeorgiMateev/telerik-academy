using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace _4.DownloadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program downloads a .jpg file to the user's desktop.");

            Console.Write("The path to the file: ");
            string URL = Console.ReadLine();

            Console.WriteLine("Enter file name.");
            string fileName = Console.ReadLine();
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + fileName + ".jpg";

            WebClient web = new WebClient();
            try
            {
                web.DownloadFile(URL, filePath);
            }
            catch (WebException e)
            {
                Console.WriteLine("There is problem with downloading this file!");
                Console.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                web.Dispose();
            }

            Console.ReadKey();
        }
    }
}
