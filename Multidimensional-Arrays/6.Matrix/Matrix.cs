using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.Matrix
{
    class Matrix
    {
        
        private double[,] matrix;

        public double this[int row, int colum]
        {
            get
            {
                return matrix[row, colum];
            }
            set
            {
                matrix[row, colum] = value;
            }
        }
        
        public int GetLenght(int dimension)
        {
            if (dimension==0)
            {
                return matrix.GetLength(0);
            }
            if (dimension==1)
            {
                return matrix.GetLength(1);
            }

            throw new IndexOutOfRangeException("There is only two dimensions in the matrix!");
        }

        public Matrix(double[,] matrix)
        {
            this.matrix = matrix;
        }
        public Matrix(int rows, int colums)
        {
            this.matrix = new double[rows, colums];
        }

        public static Matrix operator +(Matrix matr1, Matrix matr2)
        {
            if (matr1.GetLenght(0)!=matr2.GetLenght(0) || matr1.GetLenght(1)!=matr2.GetLenght(1))
            {
                throw new ArgumentException("Matrices should have same lengths!");
            }
            Matrix resultMatrix = new Matrix(matr1.GetLenght(0),matr2.GetLenght(1));
            for (int r = 0; r < matr1.GetLenght(0); r++)
            {
                for (int c = 0; c < matr1.GetLenght(1); c++)
                {
                    resultMatrix.matrix[r,c] = matr1[r, c] + matr2[r, c];
                }
            }
            return resultMatrix;
        }
        public static Matrix operator -(Matrix matr1, Matrix matr2)
        {
            if (matr1.GetLenght(0) != matr2.GetLenght(0) || matr1.GetLenght(1) != matr2.GetLenght(1))
            {
                throw new ArgumentException("Matrices should have same lengths!");
            }
            Matrix resultMatrix = new Matrix(matr1.GetLenght(0), matr2.GetLenght(1));
            for (int r = 0; r < matr1.GetLenght(0); r++)
            {
                for (int c = 0; c < matr1.GetLenght(1); c++)
                {
                    resultMatrix.matrix[r, c] = matr1[r, c] - matr2[r, c];
                }
            }
            return resultMatrix;
        }
        public static Matrix operator *(Matrix matr1, Matrix matr2)
        {
            if (matr1.GetLenght(1)!=matr2.GetLenght(0))
            {
                throw new ArgumentException("The number of first matrix's colums should be equal to the number of second matrix's rows.");
            }

            Matrix result = new Matrix(matr1.GetLenght(0), matr2.GetLenght(1));

            for (int m1r = 0; m1r < matr1.GetLenght(0); m1r++)
            {
                for (int m2c = 0; m2c < matr2.GetLenght(1); m2c++)
                {
                    double sum = 0;
                    for (int i = 0; i < matr1.GetLenght(1); i++)
                    {
                        sum += (matr1[m1r, i] * matr2[i, m2c]);
                    }
                    result[m1r, m2c] = sum;
                }
            }

            return result;
        }
        public static Matrix operator *(Matrix matr, double number)
        {
            Matrix result = new Matrix(matr.GetLenght(0), matr.GetLenght(1));
            for (int r = 0; r < matr.GetLenght(0); r++)
            {
                for (int c = 0; c < matr.GetLenght(1); c++)
                {
                    result[r, c] = matr[r, c] * number;
                }
            }
            return result;
        }

        public override string ToString()
        {
            string stringRepr="";
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    stringRepr += matrix[r, c] + " ";
                }
                stringRepr += "\r\n";
            }
            return stringRepr;
        }
    }
}
