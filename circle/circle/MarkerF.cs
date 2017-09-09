using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yandex;

namespace circle
{
    class MarkerF
    {
        public static GeoPoint Coord(string str)
        {
            GeoObjectCollection results = YandexGeocoder.Geocode(str, 1, LangType.en_US);
           

            GeoPoint gh = new GeoPoint();
            
            foreach (GeoObject re in results)
            {
                gh = re.Point;

            }
            return gh;
        }
        }
}
