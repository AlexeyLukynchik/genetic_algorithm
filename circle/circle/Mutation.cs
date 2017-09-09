using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class Mutation
    {
        public static int[] Mut(int[] f, Random ra)
        {
            //Random rand = new Random();

            int temp;
            int te;
            int a;
            te = ra.Next(0, C.cc/2+1);
            temp = ra.Next(0, C.cc-(C.cc/2+1));
            if (temp == 1)
            {
                a = f[0];
                f[0] = f[C.cc-2];
                f[C.cc-2] = a;
            }
            else
                if (temp == 2)
            {
                if (te == 1)
                {
                    a = f[0];
                    f[0] = f[C.cc-2];
                    f[C.cc-2] = a;
                }



            }



            return f;
        }
    }
}
