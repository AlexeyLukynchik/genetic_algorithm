using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class Sum
    {
        static int overall;
        static double[,] vr = Cl.second();

        public static double Summa(int[] arr)
        {
            double s = 0;

            int i = 0;

            for (int j = 1; j < arr.Length; j++)
            {
                int x = 0;
                int y = 0;
                x = arr[i];
                y = arr[j];
                s += vr[x, y];
                i++;
            }


            return s;
        }
        public static double OverallSum(double a, double b, double c, double d)
        {

            double overall = a + b + c + d;
            return overall;


        }
        public static double Coeff(double a, double o)
        {
            //double r = o / a;
            double r = a / o;
            return r;
        }

    }
}
