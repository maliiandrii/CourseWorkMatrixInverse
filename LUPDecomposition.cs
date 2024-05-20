using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class LUPDecomposition : Matrix
    {
        private double[,] LU;
        private double[,] P;
        public int comparisons;

        public LUPDecomposition(int size, double[,] matrix) : base(size, matrix)
        {
            comparisons = 0;
        }

        public double[,] Inverse()
        {
            double[,] A = matrix;
            LUPDecomp(A);
            double[,] Pb = MultiplyMatrices(P, Identity(size));
            double[,] Ainv = LUPSolve(LU, Pb);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Ainv[i, j] = Math.Round(Ainv[i, j], 5);
                }
            }

            return Ainv;
        }

        private double[,] LUPSolve(double[,] LU, double[,] b)
        {
            int rowb = b.GetLength(0);
            int colb = b.GetLength(0);
            double[,] x = new double[rowb, colb];
            double[,] y = new double[rowb, colb];
            int N = LU.GetLength(0);

            for (int q = 0; q < colb; q++)
            {
                for (int i = 0; i < N; i++)
                {
                    y[i, q] = b[i, q];
                    int j = 0;
                    while (j < i)
                    {
                        y[i, q] -= LU[i, j] * y[j, q];
                        j++;

                        comparisons++;
                    }
                }

                for (int i = N - 1; i > -1; i--)
                {
                    x[i, q] = y[i, q];
                    int j = i + 1;
                    while (j < N)
                    {
                        x[i, q] -= LU[i, j] * x[j, q];
                        j++;

                        comparisons++;
                    }
                    x[i, q] = x[i, q] / LU[i, i];
                }
            }

            return x;
        }

        private void LUPDecomp(double[,] A)
        {
            int N = A.GetLength(0);
            double[,] P = Identity(N);
            int exchanges = 0;

            for (int i = 0; i < N; i++)
            {
                double Umax = 0;
                int row = i;

                for (int r = i; r < N; r++)
                {
                    double Uii = A[r, i];
                    int q = 0;
                    while (q < i)
                    {
                        Uii -= A[r, q] * A[q, i];
                        q++;

                        comparisons++;
                    }
                    if (Math.Abs(Uii) > Umax)
                    {
                        Umax = Math.Abs(Uii);
                        row = r;
                    }
                }

                if (i != row)
                {
                    exchanges++;
                    for (int q = 0; q < N; q++)
                    {
                        double tmp = P[i, q];
                        P[i, q] = P[row, q];
                        P[row, q] = tmp;
                        tmp = A[i, q];
                        A[i, q] = A[row, q];
                        A[row, q] = tmp;

                        comparisons++;
                    }
                }

                for (int j = i; j < N; j++)
                {
                    int q = 0;
                    while (q < i)
                    {
                        A[i, j] -= A[i, q] * A[q, j];
                        q++;

                        comparisons++;
                    }
                }

                for (int j = i + 1; j < N; j++)
                {
                    int q = 0;
                    while (q < i)
                    {
                        A[j, i] -= A[j, q] * A[q, i];
                        q++;

                        comparisons++;
                    }
                    A[j, i] /= A[i, i];
                }
            }

            this.P = P;
            this.LU = A;
        }

        private double[,] Identity(int N)
        {
            double[,] I = new double[N, N];
            for (int j = 0; j < N; j++)
            {
                for (int k = 0; k < N; k++)
                {
                    I[j, k] = 0;
                }
                I[j, j] = 1;
            }
            return I;
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
    }
}
