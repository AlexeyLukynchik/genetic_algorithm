using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle
{
    class dob
    {
        public static SortedDictionary<double, int[]> dd(double s1, double s2, double s3, double s4, double sd, double sr, int[] f1, int[] f2, int[] f3, int[] f4, int[] fd)
        {
            SortedDictionary<double, int[]> vre = new SortedDictionary<double, int[]>();


            sr += s4;

            vre = Inspection.Insp(vre, s1, f1);

            vre = Inspection.Insp(vre, s2, f2);


            vre = Inspection.Insp(vre, s3, f3);

            vre = Inspection.Insp(vre, s4, f4);
            if (vre.Count < 4)
            {
                sd = sr / sd;
                vre = Inspection.Insp(vre, sd, fd);

            }

            return vre;


        }
    }
}
