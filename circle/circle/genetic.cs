using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class genetic
    {
        public static string aaa;
        public static string bbb;
        public static int[] fmap = new int[C.cc];
        public static void Apop(SortedDictionary<double, int[]> p, Random rand)
        {
            //SortedDictionary<double, int[]> vre = new SortedDictionary<double,int[]>();
            List<int[]> po = new List<int[]>();
            int[] CH1 = new int[5];
            int[] CH2 = new int[5];
            int[] CH3 = new int[5];
            int[] CH4 = new int[5];
            int[] CHD = new int[5];
            int count = 0;
            //List<int[]> allvid = new List<int[]>();
            double[] h = new double[4];
            //double[] nol = new double[]{0,0,0,0,0};

            int o = 0;


            while (count < 4)
            {


                foreach (var fg in p.Keys)
                {
                    h[o] = fg;
                    o++;
                }

                //CHD = p[h[3]];
                CHD = p[h[o-1]];
                po = Crossover.Cross(p, rand, count);
                CH1 = po[0];
                CH2 = po[1];
                CH3 = po[2];
                CH4 = po[3];

                double summa1 = Sum.Summa(CH1);
                double summa2 = Sum.Summa(CH2);
                double summa3 = Sum.Summa(CH3);
                double summa4 = Sum.Summa(CH4);
                double summaD = Sum.Summa(CHD);
                double allp = Sum.OverallSum(summa1, summa2, summa3, summa4);
                double srt = summa1 + summa2 + summa3;
                summa1 = Sum.Coeff(summa1, allp);
                summa2 = Sum.Coeff(summa2, allp);
                summa3 = Sum.Coeff(summa3, allp);
                summa4 = Sum.Coeff(summa4, allp);
                //summaD = Sum.Coeff(summaD, allp);
                //int[] pustoi = new int[] { 0, 0, 0, 0, 0 };
                //foreach (double h in vre.Keys.Cast<double>().ToArray())
                //    vre[h] = pustoi;

                //vre = Inspection.Insp(vre, summa1, CH1);

                //vre = Inspection.Insp(vre, summa2, CH2);


                //vre = Inspection.Insp(vre, summa3, CH3);

                //vre = Inspection.Insp(vre, summa4, CH4);




                p = dob.dd(summa1, summa2, summa3, summa4, srt, summaD, CH1, CH2, CH3, CH4, CHD);

                count++;
                o = 0;
                srt = 0;
                //Console.WriteLine("я все еще здесь!{0}",count);
            }
            foreach (var fg in p.Keys)
            {
                h[o] = fg;
                o++;
            }

            int[] anw = new int[C.cc];
            anw = p[h[0]];
            genetic.fmap = anw;
            double rast1 = looping.startFinish(anw[0].ToString());
            double rast2 = looping.startFinish(anw[anw.Length-1].ToString());
            double dlinaanw = Sum.Summa(anw);
            dlinaanw = dlinaanw + rast1 + rast2 + 50*C.cc;
           // Console.WriteLine("Возможный маршрут = ");
            string answerResuit = "";
            
            for(int i =0;i<anw.Length;i++)
                answerResuit = answerResuit + "-->" + C.g[anw[i]];

            answerResuit = answerResuit + "-->" + C.start;
            answerResuit = C.start + answerResuit;
            /*
        for (int i = 0; i < anw.Length; i++)
            Console.Write("{0}", anw[i]);*/

            // Console.WriteLine("Стоимость данного маршрута = {0}", dlinaanw);
            int adl = (int)dlinaanw;
            //string dli = dlinaanw.ToString();
            string dli = adl.ToString() + "  km";
           // genetic.aaa = genetic.Marsh(genetic.SMA(anw));
            genetic.bbb = genetic.Dlinam(dli);
            genetic.aaa = answerResuit;

        }
        private static string SMA(int[] r)
        {
            string fa = r[0].ToString();
            for (int i = 1; i < r.Length; i++)
            {

                fa = fa + r[i].ToString();
            }
            return fa;
        }

        public static string Marsh(string fga)
        {

            return fga;
        }
        public static string Dlinam(string dga)
        {

            return dga;
        }

    }
}
