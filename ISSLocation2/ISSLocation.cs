using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ISSLocation2
{
    static class ISSLocation
    {
        public static string ISSLat;
        public static string ISSLong;
        public static double ISSDLat;               //D Lat and D long are just the decimal equivelent to use with the geolocator
        public static double ISSDLong;
        public static string ISSState;              //State is only used in certain places
        public static string ISSCountry;            //figure out about getting more location options for UI such as state/region even in different countries
        public static bool bodyOfWater = false;     //Will change if ISS is over water
        public static DateTime timeAccessed;

        public static void setISSLocation()
        {
            WebClient wc = new WebClient();

            //Data from ISS API
            var jsonData = wc.DownloadString("http://api.open-notify.org/iss-now.json");
            dynamic ISSLongLat = JValue.Parse(jsonData);
            ISSLat = ISSLongLat.iss_position.latitude;
            ISSLong = ISSLongLat.iss_position.longitude;
            ISSDLat = Convert.ToDouble(ISSLat);
            ISSDLong = Convert.ToDouble(ISSLong);

            //Data from the geolocation API
            jsonData = wc.DownloadString("https://api.opencagedata.com/geocode/v1/json?key=63b2ec09725548cfa0a12341ed9b44c1&q=" + ISSLat + "%2C+" + ISSLong + "&pretty=1&no_annotations=1");
            dynamic ISSInfo = JValue.Parse(jsonData);
            timeAccessed = UnixTimeStampToDateTime((double)ISSInfo.timestamp.created_unix);
            try
            {
                if (ISSInfo.results[0].components._type == "body_of_water")
                {
                    bodyOfWater = true;
                }
                else
                {
                    bodyOfWater = false;
                    ISSCountry = ISSInfo.results[0].components.country;
                    ISSState = ISSInfo.results[0].components.state;
                }
            }
            catch
            {
                ISSCountry = "The ISS is currently over a remote location, please try again soon!";               
            }
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}
