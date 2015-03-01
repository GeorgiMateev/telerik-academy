using System;


namespace PrintFirst100
{
    class Program
    {
        static void Main()
        {
            int a = 2;
            int b = -3;

            Console.Write("{0} {1} ", a, b);

            for (int i = 0; i < 48; i++)
            {
                a += 2;
                b -= 2;

                Console.Write("{0} {1} ",a,b);
            }
            Console.ReadKey(false);
        }
    }
}
