using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class Inspection
    {
        public static SortedDictionary<double, int[]> Insp(SortedDictionary<double, int[]> d, double ke, int[] va)
        {
            long xit = 100000;

            int csc = 0;
            double[] yti = new double[4];
            int i = 0;
            foreach (double c in d.Keys)
            {
                yti[i] = c;
                i++;
            }
            for (int j = 0; j < yti.Length; j++)
            {

                if (yti[j] == ke)
                    csc++;
            }
            if (csc == 0)
            {
                d.Add(ke, va);
            }
            else
            {

                ke += Math.Pow(xit, -csc);
                try
                {
                    d.Add(ke, va);
                }
                catch (Exception ex)
                {
                    ke += Math.Pow(xit, -csc + 1);
                    //Console.WriteLine("Ошибка: "+ex);

                }
            }
            return d;
        }
    }
}
