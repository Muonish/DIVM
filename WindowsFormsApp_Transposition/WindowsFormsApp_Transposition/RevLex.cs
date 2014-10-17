using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Transposition
{
    public class RevLex
    {
        int N;
        int[] vector;
        FormMain parent;

        public RevLex(int n, FormMain p)
        {
            parent = p;
            N = n;
            vector = new int[N];
            for (int i = 0; i < N; i++)
                vector[i] = i + 1;
            antylex(N);
        }

        private void antylex(int m)
        {
            int tmp;

            if (m == 0)
                vectorOutput();
            else
            {
                for (int i = 0; i < m; i++)
                {
                    antylex(m - 1);
                    if (i < m - 1)
                    {
                        tmp = vector[i];
                        vector[i] = vector[m - 1];
                        vector[m - 1] = tmp;
                        reverse(m - 1);
                    }
                }
            }     
        }
        private void reverse(int m)
        {
            int i = 0;
            int j = m - 1;
            int tmp;

            while (i < j)
            {
                tmp = vector[i];
                vector[i] = vector[j];
                vector[j] = tmp;
                i++;
                j--;
            }
        }
        private void vectorOutput()
        {
            for (int i = 0; i < N; i++)
            {
                parent.textBoxOutput.Text += vector[i].ToString() + "   ";
            }
            parent.textBoxOutput.Text += Environment.NewLine;
        }

    }
}
