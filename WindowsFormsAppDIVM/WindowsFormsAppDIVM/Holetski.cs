using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppDIVM
{
    class Holetski
    {
        public static double[] TestSolve(double[,] matrix, double[] vector)
        {
            int i, j, p;
            int n = vector.Length;
            double[][] B, C;
            B = new double[n][];
            C = new double[n][];

            for (i = 0; i < n; i++)
            {
                B[i] = new double[n];
                C[i] = new double[n];
            }

            for (i = 0; i < n; i++)
            {
                B[i][0] = matrix[i,0];
                C[0][i] = matrix[0,i] / B[0][0];
                if (i != 0)
                {
                    C[i][i] = 1;
                }
            }

            double Sum;

            for (i = 1; i < n; i++)
            {
                for (j = 1; j < n; j++)
                {
                    if (j > i)
                    {
                        Sum = 0;
                        for (p = 0; p <= i - 1; p++)
                        {
                            Sum += (B[i][p] * C[p][j]);
                        }
                        C[i][j] = ((matrix[i,j] - Sum) / B[i][i]);
                    }
                    if (i >= j)
                    {
                        Sum = 0;
                        for (p = 0; p <= j - 1; p++)
                        {
                            Sum += (B[i][p] * C[p][j]);
                        }
                        B[i][j] = matrix[i,j] - Sum;
                    }
                }
            }

            double[] y = new double[n];
            double[] x = new double[n];
            y[0] = vector[0] / B[0][0];

            for (i = 1; i < n; i++)
            {
                Sum = 0;
                for (p = 0; p <= i - 1; p++)
                {
                    Sum += (B[i][p] * y[p]);
                }
                y[i] = (vector[i] - Sum) / B[i][i];
            }
            x[n - 1] = y[n - 1];
            for (i = n - 2; i >= 0; i--)
            {
                Sum = 0;
                for (j = i + 1; j < n; j++)
                {
                    Sum += C[i][j] * x[j];
                }
                x[i] = y[i] - Sum;
            }

            return x;
        }


        public static bool IsSymmetric(double[,] m, int N)
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    if (m[i, j] != m[j, i])
                        return false;
            
            return true;
        }

    }

    
}
