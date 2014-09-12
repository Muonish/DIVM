using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppDIVM
{
    class Gauss
    {
        public double[,] matrix;
        public double[] vector;
        public double[] answer;
        private int N = 0;

        public Gauss(double[,] m, double[] v)
        {
            matrix = m;
            vector = v;

            N = vector.Length;
            answer = new double[N];

            for (int i = 0; i < N; i++)
            {
                answer[i] = 0;
                
            }
        }

        private void SortRows(int SortIndex)
        {

            double MaxElement = matrix[SortIndex,SortIndex];
            int MaxElementIndex = SortIndex;
            for (int i = SortIndex + 1; i < N; i++)
            {
                if (matrix[i,SortIndex] > MaxElement)
                {
                    MaxElement = matrix[i,SortIndex];
                    MaxElementIndex = i;
                }
            }

            //find max element and make it first
            if (MaxElementIndex > SortIndex)//if it isn't the 1st element
            {
                double temp;

                temp = vector[MaxElementIndex];
                vector[MaxElementIndex] = vector[SortIndex];
                vector[SortIndex] = temp;

                for (int i = 0; i < N; i++)
                {
                    temp = matrix[MaxElementIndex,i];
                    matrix[MaxElementIndex,i] = matrix[SortIndex,i];
                    matrix[SortIndex,i] = temp;
                }
            }
        }

        public int Solvematrix()
        {
            for (int i = 0; i < N - 1; i++)
            {
                SortRows(i);
                for (int j = i + 1; j < N; j++)
                {
                    if (matrix[i,i] != 0) //if the main element != 0, then calculate
                    {
                        double MultElement = matrix[j,i] / matrix[i,i];
                        for (int k = i; k < N; k++)
                            matrix[j,k] -= matrix[i,k] * MultElement;
                        vector[j] -= vector[i] * MultElement;
                    }
                }
            }
            bool flag = false;
            for (int i = (N - 1); i >= 0; i--)
            {
                answer[i] = vector[i];

                for (int j = (N - 1); j > i; j--)
                {
                    answer[i] -= matrix[i,j] * answer[j];
                }
                
                if (matrix[i,i] == 0)
                {
                    if (vector[i] == 0)
                    {
                        flag = true; //infinitely many solutions
                    }
                    else
                    {
                        return 1; //no solution
                    }
                }
                answer[i] /= matrix[i,i];
            }
            if (flag) return 2;
            return 0;
        }

    }
}
