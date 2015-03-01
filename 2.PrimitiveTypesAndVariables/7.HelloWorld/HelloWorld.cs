using System;

namespace _7.HelloWorld
{
    class HelloWorld
    {
        static void Main()
        {
            string s1 = "Hello";
            string s2 = "World";
            object s1s2 = s1 + " " + s2;
            string helloWorld = (string)s1s2;
            Console.WriteLine(helloWorld);

            Console.ReadKey(false);
        }
    }
}
