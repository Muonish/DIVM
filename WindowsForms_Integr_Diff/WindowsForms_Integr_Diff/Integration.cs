using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Integr_Diff
{
    class Integration
    {
        public double Simpson(double a, double b, double eps)
        {
            double result;
            double step = b - a;
            double f2 = a;
            double checkfunc;
            double funcOfab;
            double x;

            if ((checkfunc = funcForIntegration(a)) == 0)
            {
                ErrorMessage(a);
                return 0;
            }
            funcOfab = checkfunc;
            if ((checkfunc = funcForIntegration(b)) == 0)
            {
                ErrorMessage(b);
                return 0;
            }
            funcOfab += checkfunc;
            do
            {
                double f3 = f2;
                step /= 2;
                double f1 = 0;
                x = a + step;
                do
                {
                    if ((checkfunc = funcForIntegration(x)) == 0)
                    {
                        ErrorMessage(x);
                        return 0;
                    }
                    f1 = f1 + 2 * checkfunc;
                    x = x + 2 * step;
                } while (x < b);
                funcOfab = funcOfab + f1;
                f2 = (funcOfab + f1) * step / 3;
                x = Math.Abs((f3 - f2) / 15);
            } while (x > eps);
            result = f2;

            return result;
        }
        public double Gauss(double a, double b, double eps)
        {
            double checkfunc = 1;
            double result = 1.0;
            double[] X = { 0.0694318, 0.3300095, 0.6699905, 0.9305682 };
            double[] A = { 0.1739274, 0.3260726, 0.3260726, 0.1739274 };
            int n = 4;
            int k = 1;
            double step = Double.MaxValue;
            double s;
            double x;
            while (step >= eps)
            {
                k = k * 2;
                step = (b - a) / k;
                s = 0;
                for (int j = 0; j < k; j++)
                {
                    x = a + j * step;
                    for (int i = 0; i < n; i++)
                    {
                        x = x + X[i] * step;
                        if ((checkfunc = funcForIntegration(x)) == 0)
                        {
                            ErrorMessage(x);
                            return 0;
                        }
                        s += checkfunc * A[i];
                    }
                }
                result = step * s;
            }
            return result;
        }


        public double funcForIntegration(double x)
        {
            double denominator = 2 * Math.Sin(x);
            if ((Math.Abs(denominator) <= 0.00001) && (denominator > 0)) return 0;
            return Math.Cos(2 * x) / denominator;
        }
        //public double funcForIntegration(double x)
        //{
        //    double denominator = Math.Cos(x) * Math.Cos(x);
        //    if ((Math.Abs(denominator) <= 0.00001) && (denominator > 0)) return 0;
        //    return 1 / denominator;
        //}
        public void ErrorMessage(double x)
        {
            MessageBox.Show("Impossible to calculate in this interval! " + "Discontinuity point x = " + Convert.ToString(Math.Round(x, 4)));
        }
    }
}
