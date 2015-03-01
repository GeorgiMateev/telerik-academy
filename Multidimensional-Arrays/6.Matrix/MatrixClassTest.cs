using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.Matrix
{
    class MatrixClassTest
    {
        static void Main()
        {
            Console.WriteLine("Matrix 1");
            Matrix matrix1 = new Matrix(new double[,]{ {3,5,2}, {6,4,3} } );
            string strM = matrix1.ToString();
            Console.WriteLine(matrix1);

            Console.WriteLine("Matrix 2");
            Matrix matrix2 = new Matrix(new double[,]
            {
                {1,2,3},
                {10,15,13}
            });
            Console.WriteLine(matrix2.ToString());            

            Console.WriteLine("M1 + M2");
            Matrix resultSum = matrix1 + matrix2;
            Console.WriteLine(resultSum.ToString());

            Console.WriteLine("M1 - M2");
            Matrix subtrakt = matrix1 - matrix2;
            Console.WriteLine(subtrakt.ToString());

            Console.WriteLine("Matrix 3");
            Matrix matrix3 = new Matrix(new double[,]
            {
                {1,3,-1},
                {0,-2,2},
            });
            Console.WriteLine(matrix3.ToString());

            Console.WriteLine("Matrix 4");
            Matrix matrix4 = new Matrix(new double[,]
            {
                {7,9},
                {5,2},
                {2,1}
            });
            Console.WriteLine(matrix4.ToString());

            Matrix multiply = matrix3 * matrix4;
            Console.WriteLine("M3 * M4");
            Console.WriteLine(multiply.ToString());

            Console.WriteLine("M4 * -6,4");
            Matrix multByNumber = matrix4 * -6.4;
            Console.WriteLine(multByNumber.ToString());

            Console.ReadKey();
        }
    }
}
