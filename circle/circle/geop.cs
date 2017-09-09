using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yandex;
namespace circle
{
    class geop
    {

    public static double ff (string str1,string str2)
    {
            GeoObjectCollection results = YandexGeocoder.Geocode(str1, 1, LangType.en_US);
            GeoObjectCollection results1 = YandexGeocoder.Geocode(str2, 1, LangType.en_US);

            GeoPoint gh = new GeoPoint();
            GeoPoint gh1 = new GeoPoint();
            foreach (GeoObject re in results)
            {
                gh = re.Point;

            }
            foreach (GeoObject re in results)
            {
                gh = re.Point;

            }
            foreach (GeoObject re in results1)
            {
                gh1 = re.Point;

            }

            if (gh.Lat == 0.0 || gh.Long == 0.0 || gh1.Lat == 0.0 || gh1.Long == 0.0)
            {
                MessageBox.Show("неправильно ввели город");
                Environment.Exit(0);
                return 0;
            }
            else {
                double pii = Math.PI / 180;
                double lat1 = gh.Lat * pii;//gh.Lat*pii;
                double long1 = gh.Long * pii;
                double lat2 = gh1.Lat * pii;
                double long2 = gh1.Long * pii;
                double result = Math.Acos(Math.Sin(lat1) * Math.Sin(lat2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Cos(long1 - long2));

                double cl1 = Math.Cos(lat1);
                double cl2 = Math.Cos(lat2);
                double sl1 = Math.Sin(lat1);
                double sl2 = Math.Sin(lat2);
                double delta = long2 - long1;
                double cdelta = Math.Cos(delta);
                double sdelta = Math.Sin(delta);
                double y = Math.Sqrt(Math.Pow(cl2 * sdelta, 2) + Math.Pow(cl1 * sl2 - sl1 * cl2 * cdelta, 2));
                double x = sl1 * sl2 + cl1 * cl2 * cdelta;
                double ad = Math.Atan2(y, x);
                double dist = ad * 6372795;

                return result * 6371;
            }
        }

    }
}
