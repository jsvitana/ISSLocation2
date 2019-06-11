using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ISSLocation2
{
    static class SerializeData
    {
        public static void save(string ISSReadings)
        {
            if (!File.Exists(@"C:\intel\iss2.dat"))    //Creates initial file if it does not exist
            {
                Stream file = File.Create(@"C:\Intel\iss2.dat");
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(file, ISSReadings);
                file.Close();
            }
            else           //Just appends to the string and overrwrites the file with most recent being FIRST
            {
                string oldData = read();
                string allData = ISSReadings + "\r\n"+ oldData;

                Stream file = File.Create(@"C:\Intel\iss2.dat");
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(file, allData);
                file.Close();
            }
        }

        public static string read()
        {
            string allData = "";

            try
            {
                Stream openFileStream = File.OpenRead(@"C:\Intel\iss2.dat");
                BinaryFormatter deserializer = new BinaryFormatter();
                allData = (string)deserializer.Deserialize(openFileStream);
                openFileStream.Close();               
            }
            catch
            {
                allData = "Sorry, you dont seem to have any data yet...";
            }
            return allData;
        }

        public static void clearLogs()
        {
            File.Delete(@"C:\Intel\iss2.dat");           
        }
    }
}
