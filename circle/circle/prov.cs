using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class prov
    {
        public static bool g(List<int[]> l, int[] k)
        {
            bool c = false;
            for (int i = 0; i < l.Count; i++)
            {
                c = l[i].SequenceEqual(k);
                if (c)
                    break;

            }


            return c;
        }
        public static bool g(int[] ll, int[] k)
        {
            bool c = false;

            c = ll.SequenceEqual(k);




            return c;
        }
        public static int[] ft(int[] j, Random rando)
        {
            int u1 = rando.Next(0, 4);
            int u2 = rando.Next(0, 4);
            int jo;
            jo = j[2];
            j[2] = j[1];
            j[1] = jo;
            return j;

        }
    }
}
