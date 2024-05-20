using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SchultzInverse : Matrix
    {
        public int comparisons;
        public SchultzInverse(int size, double[,] matrix) : base(size, matrix)
        {
            comparisons = 0;
        }

        public double[,] Inverse()
        {
            double[,] A = matrix;
            double[,] U0 = ZeroMatrixApproximation(A);
            int size = this.size;
            double[,] E = new double[size, size];
            double[,] AU = new double[size, size];
            double[,] y = new double[size, size];
            double[,] yT = new double[size, size];
            double[,] EY = new double[size, size];
            double e = Math.Pow(10, -5);
            double exit = 9999;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j) E[i, j] = 1;
                    else E[i, j] = 0;
                }
            }

            while (exit > e)
            {

                AU = MultiplyMatrices(A, U0);

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        y[i, j] = E[i, j] - AU[i, j];

                        comparisons++;
                    }
                }


                double sum = 0;
                for (int i = 0; i < size; ++i)
                {
                    for (int j = 0; j < size; j++)
                    {
                        sum += Math.Pow(y[i, j], 2);

                        comparisons++;
                    }
                }


                exit = Math.Sqrt(sum);

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        EY[i, j] = E[i, j] + y[i, j];

                        comparisons++;
                    }
                }

                U0 = MultiplyMatrices(U0, EY);
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    U0[i, j] = Math.Round(U0[i, j], 5);
                }
            }

            return U0;
        }


        private double[,] TransposeMatrix(double[,] matrix)
        {
            int size = matrix.GetLength(0);
            double[,] result = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }

            return result;
        }

        private double[,] MultiplyMatrices(double[,] matrix1, double[,] matrix2)
        {
            int size = matrix1.GetLength(0);
            double[,] result = new double[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return result;
        }

        private double[,] ZeroMatrixApproximation(double[,] matrix)
        {
            int size = matrix.GetLength(0);
            double[,] result = new double[size, size];

            double[,] matrixT = TransposeMatrix(matrix);
            double[,] matrixMul = MultiplyMatrices(matrix, matrixT);

            double sum = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    sum += Math.Pow(matrixMul[i, j], 2);

                    comparisons++;
                }
            }
            double d = Math.Sqrt(sum);


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = matrixT[i, j] / d;

                    comparisons++;
                }
            }

            return result;
        }
    }
}
