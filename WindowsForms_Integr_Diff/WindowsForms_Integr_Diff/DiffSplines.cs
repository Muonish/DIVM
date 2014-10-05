using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_Integr_Diff
{
    class DiffSplines
    {
        public double firstDifferential;
        public double secondDifferential;

        public void Spline(double a, double b, double x)
        {
            int i;
            int n = 10000;
            double firstDiff = 0;
            double secondDiff = 0;
            double h, h1, h2, aa;
            double[] y = new double[n - 1];
            h = (b - a) / n;
            aa = a;
            for (i = 0; i < n - 1; i++)
            {
                y[i] = funcForDiff(aa);
                aa += h;
            }
            i = (int)((x - a) / h + h / 2);
            h1 = 2 * h;
            h2 = h * h;
            if (i == 0)
            {
                firstDiff = (-3 * y[0] + 4 * y[1] - y[2]) / h1;
                secondDiff = (2 * y[0] - 5 * y[1] + 4 * y[2] - y[3]) / h2;
            }
            if (i > 0 && i < (y.Length - 1))
            {
                firstDiff = (-y[i - 1] + y[i + 1]) / h1;
                secondDiff = (y[i - 1] - 2 * y[i] + y[i + 1]) / h2;
            }
            if (i == (y.Length - 1))
            {
                firstDiff = (y[n - 2] - 4 * y[n - 1] + 3 * y[n]) / h1;
                secondDiff = (-y[n - 3] + 4 * y[n - 2] - 5 * y[n - 1] + 2 * y[n]) / h2;
            }
            firstDifferential = firstDiff;
            secondDifferential = secondDiff;
        }
        public double funcForDiff(double x)
        {
            return Math.Log(x, Math.Exp(1)) + Math.Cos(x) / x;
        }
        //public double funcForDiff(double x)
        //{
        //    return Math.Sqrt(1 + x * x) / x;
        //}
    }
}
