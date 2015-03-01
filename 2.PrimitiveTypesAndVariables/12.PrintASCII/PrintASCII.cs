using System;


namespace _12.PrintASCII
{
    class PrintASCII
    {
        static void Main()
        {
            for (int i = 0; i < 128; i++)
            {
                Console.Write("{0} ",(char)i);
            }

            Console.ReadKey(false);
        }
    }
}
