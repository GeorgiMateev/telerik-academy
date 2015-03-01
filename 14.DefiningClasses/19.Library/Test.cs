using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19.Library
{
    class Test
    {
        static void Main()
        {
            Library lib = new Library("MyLibrary");
            Book programirane = new Book("Nakov", "Intro Programming", "telerik", "IS213");
            Book discrete = new Book("Manev", "Discrete Math", "SU", "IS234234", 2005);

            lib.AddBook(programirane,discrete);

            string print = lib.FormatPrintBooks();
            Console.WriteLine(print);

            lib.DeleteBook(programirane);

            string printAfter = lib.FormatPrintBooks();
            Console.WriteLine(printAfter);

            Console.ReadKey();
        }
    }
}
