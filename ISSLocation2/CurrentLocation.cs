using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ISSLocation2
{
    static class CurrentLocation
    {
        
        public static string currentCity;
        public static string currentState;
        public static string currentZip;
        public static string currentLat;
        public static string currentLong;
        public static double currentDLat;
        public static double currentDLong;

        public static void setLocation()
        {
            WebClient wc = new WebClient();

            //Get info about location of IP address
            var jsonData = wc.DownloadString("http://ip-api.com/json/");
            dynamic locationObject = JValue.Parse(jsonData);

            currentCity = locationObject.city;
            currentState = locationObject.regionName;
            currentZip = locationObject.zip;

            //GeoLocation API Information
            jsonData = wc.DownloadString("https://api.opencagedata.com/geocode/v1/json?key=63b2ec09725548cfa0a12341ed9b44c1&q=" + currentCity + "%2C" + currentState + "%2C+" + currentZip + "&pretty=1&no_annotations=1");
            dynamic cityToLatLong = JValue.Parse(jsonData);
            currentLat = cityToLatLong.results[0].bounds.northeast.lat;
            currentLong = cityToLatLong.results[0].bounds.northeast.lng;
            currentDLat = Convert.ToDouble(currentLat);
            currentDLong = Convert.ToDouble(currentLong);
        }
    }
}
