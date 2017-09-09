using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class Starp
    {
        public static void Startpop()
        {


            SortedDictionary<double, int[]> popul = new SortedDictionary<double, int[]>();
            Random rand = new Random();

            int[] a1 = Rand.Randm(rand);
            bool ff = false;

            int[] a2 = Rand.Randm(rand);
            ff = prov.g(a1, a2);
            while (ff)
            {
                a2 = Rand.Randm(rand);
                ff = prov.g(a1, a2);
                if (!ff)
                    break;

            }
            int[] a3 = Rand.Randm(rand);
            ff = prov.g(a1, a3);
            while (ff)
            {
                a3 = Rand.Randm(rand);
                ff = prov.g(a1, a3);
                if (!ff)
                    break;

            }
            ff = prov.g(a2, a3);
            while (ff)
            {
                a3 = Rand.Randm(rand);
                ff = prov.g(a2, a3);
                if (!ff)
                    break;

            }
            int[] a4 = Rand.Randm(rand);
            ff = prov.g(a1, a4);
            while (ff)
            {
                a4 = Rand.Randm(rand);
                ff = prov.g(a1, a4);
                if (!ff)
                    break;

            }
            ff = prov.g(a2, a4);
            while (ff)
            {
                a4 = Rand.Randm(rand);
                ff = prov.g(a2, a4);
                if (!ff)
                    break;

            }
            ff = prov.g(a3, a4);
            while (ff)
            {
                a4 = Rand.Randm(rand);
                ff = prov.g(a3, a4);
                if (!ff)
                    break;

            }
            double summ1 = Sum.Summa(a1);
            double summ2 = Sum.Summa(a2);
            double summ3 = Sum.Summa(a3);
            double summ4 = Sum.Summa(a4);

            double alls = Sum.OverallSum(summ1, summ2, summ3, summ4);

            summ1 = Sum.Coeff(summ1, alls);
            summ2 = Sum.Coeff(summ2, alls);
            summ3 = Sum.Coeff(summ3, alls);
            summ4 = Sum.Coeff(summ4, alls);


            //потом проверка на одиноковость и дополняем
            popul = Inspection.Insp(popul, summ1, a1);

            popul = Inspection.Insp(popul, summ2, a2);


            popul = Inspection.Insp(popul, summ3, a3);

            popul = Inspection.Insp(popul, summ4, a4);

            genetic.Apop(popul, rand);
            //  Console.WriteLine("the end!");
            // Console.ReadKey();

        }
            }
    
       }