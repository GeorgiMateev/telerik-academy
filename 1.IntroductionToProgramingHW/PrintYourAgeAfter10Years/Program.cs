using System;


namespace PrintYourAgeAfter10Years
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after ten years will be: {0}", age+10);

            Console.ReadKey(false);
        }
    }
}
