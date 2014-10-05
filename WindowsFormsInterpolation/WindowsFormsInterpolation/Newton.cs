using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsInterpolation
{
    class Newton
    {
        public static double InterpolateNewton(double x, double[] xValues, double[] yValues, int size)
        {
            double res = yValues[0], F, den;
            int i, j, k;
            for(i = 1; i < size; i++){
                F = 0;
                for (j = 0; j <= i; j++)
                {//следующее слагаемое полинома
                    den = 1;
        //считаем знаменатель разделенной разности
                    for( k = 0; k <= i; k++)
                    {
                        if (k != j) 
                            den*=(xValues[j]-xValues[k]);
                    }
        //считаем разделенную разность
                    F += yValues[j]/den;
                }
        //домножаем разделенную разность на скобки (x-x[0])...(x-x[i-1])
                for ( k = 0; k < i; k++)
                    F *= (x - xValues[k]);
                res += F;//полином
            }
        return res;

        }
    }
}
