using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yandex;

namespace circle
{
    class Cl
    {
        public int[] a = new int[C.cc];


        public static int[] first()
        {
            int[] u = new int[C.cc];

            int j = 0;
            foreach (var t in C.g.Keys)
            {
                u[j] = t;
                j++;
            }
            return u;
        }
        public static double[,] second()
        {
            double[,] marsha = new double[C.cc+1 , C.cc+1];
            int[] h = new int[C.cc];
            h = Cl.first();

            for (int i = 0; i < h.Length - 1; i++)
                for (int j = 1; j < h.Length; j++)
                {
                    marsha[h[i], h[j]] = geop.ff(C.g[h[i]], C.g[h[j]]);
                    marsha[h[j], h[i]] = geop.ff(C.g[h[i]], C.g[h[j]]);
                }

            return marsha;
        }
    } 
    }
