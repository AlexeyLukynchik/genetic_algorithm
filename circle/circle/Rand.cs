using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class Rand
    {
        public static int[] Randm(Random rand)
        {

            int[] a0 = new int[C.cc];
            int x, k = 0, l = 0;
            while (l < C.cc)
            {
                for (int i = 0; i < a0.Length; i++)
                {
                    x = rand.Next(1, C.cc+1);
                    if (k == 0)
                    {

                        a0[k] = x;
                        k++;
                        l++;
                    }
                    else
                    {
                        int m = 0;
                        for (int j = 0; j < k; j++)
                        {
                            if (a0[j] == x) m++;
                        }
                        if (m == 0)
                        {
                            a0[k] = x;
                            k++;
                            l++;
                        }
                    }
                }
            }
            return a0;
        }
    }
}
