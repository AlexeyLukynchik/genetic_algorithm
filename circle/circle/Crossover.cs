using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class Crossover
    {
        public static List<int[]> Cross(SortedDictionary<double, int[]> u, Random rand, int gggf)
        {
            List<int[]> ju = new List<int[]>();
            List<int[]> allvid = new List<int[]>();
            int[] a12 = new int[5];
            int[] a21 = new int[5];
            // Console.WriteLine("здесь");
            double[] yt = new double[4];
            int i = 0;
            foreach (double c in u.Keys)
            {
                yt[i] = c;
                i++;
            }

            int[] a1 = u[yt[0]];
            int[] a2 = u[yt[1]];
            int[] a3 = u[yt[2]];
            int[] a4 = u[yt[3]];
            a12 = Crossover.CrossAB(a1, a4);
            a21 = Crossover.CrossBA(a2, a3);
            a12 = Mutation.Mut(a12, rand);
            a21 = Mutation.Mut(a21, rand);
            bool ist = false;
            //while (!ist)
            //{
            //    ist = prov.g(b, a12);
            //    a12 = prov.ft(a12,rand);
            //}
            //ist = false;
            //while (!ist)
            //{
            //    ist = prov.g(b, a21);
            //    a21 = prov.ft(a21,rand);
            //}

            bool kj = false;

            allvid.Add(u[yt[0]]);
            kj = a1.SequenceEqual(a2);
            if (!kj)
            {
                allvid.Add(a2);
            }
            else { allvid.Add(a4); };

            //allvid.Add(u[yt[1]]);
            ist = prov.g(allvid, a12);
            if (!ist)
            {

                allvid.Add(a12);

            }
            else
            {
                a12 = Crossover.CrossAB(a12, u[yt[2]]);
                ist = false;
                while (ist)
                {
                    a12 = prov.ft(a12, rand);
                    ist = prov.g(allvid, a12);
                    if (ist)
                        break;

                }
                allvid.Add(a12);
            }
            ist = false;
            ist = prov.g(allvid, a21);
            if (!ist)
            {

                allvid.Add(a21);

            }
            else
            {
                a21 = Crossover.CrossAB(a21, u[yt[3]]);
                ist = false;
                while (ist)
                {
                    a21 = prov.ft(a21, rand);
                    ist = prov.g(allvid, a21);
                    if (ist)
                        break;

                }

                allvid.Add(a21);
            }

            //if (allvid.Count != 4)
            //{
            //    allvid.Add(a3);
            //    allvid.Add(a4);
            //}

            return allvid;

        }
        private static int[] CrossAB(int[] t1, int[] t2)
        {

            int pol = C.cc / 2 + 1;
            int poll = C.cc - pol;
            int[] fk = new int[pol];
            int[] t12 = new int[C.cc];
            int[] pp = new int[poll];

            for (int o = 0; o < pol; o++)
                fk[o] = t1[o];

            int j = 0;
            for (int o = pol; o < C.cc; o++)
            {


                pp[j] = t2[o];
                j++;

            }

            var e = fk.Union(pp).ToArray<int>();
            fk = e;
            int[] chi = new int[C.cc];//{ 1, 2, 3, 4, 5 };
            int lolo = 1;
            for(int v = 0;v<C.cc;v++)
            {
                chi[v] = lolo;
                lolo++;

            }
            var ee = fk.Union(chi).ToArray<int>();
            t12 = ee;
            return t12;
        }
        private static int[] CrossBA(int[] t1, int[] t2)
        {

            int pol = C.cc / 2 + 1;
            int poll = C.cc - pol;
            int[] fk = new int[pol];
            int[] t21 = new int[C.cc];
            int[] pp = new int[poll];

            for (int o = 0; o < pol; o++)
                fk[o] = t2[o];



            int j = 0;
            for (int o = pol; o < C.cc; o++)
            {


                pp[j] = t1[o];
                j++;

            }

            var e = fk.Union(pp).ToArray<int>();
            fk = e;
            int[] chi = new int[C.cc];// { 1, 2, 3, 4, 5 };
            int lolo = 1;
            for (int v = 0; v < C.cc; v++)
            {
                chi[v] = lolo;
                lolo++;

            }
            var ee = fk.Union(chi).ToArray<int>();
            t21 = ee;
            return t21;
        }
    }
}
