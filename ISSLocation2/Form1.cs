using Geolocation;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISSLocation2
{
    public partial class ISSForm : Form
    {
        WebClient wc = new WebClient();
        Stopwatch watch = new Stopwatch();

        public ISSForm()
        {
            InitializeComponent();

            CurrentLocation.setLocation();                //Up here so it sets your current location and displays it in the box since this method will only need to run once
            currentLocationTxtBox.Text = CurrentLocation.currentZip;

            ISSPicBox.SizeMode = PictureBoxSizeMode.StretchImage;   //Makes image fit into the image box
            ISSPicBox.Image = Properties.Resources.ISSPic;          //Gets png from project resources
        }

        private void currentLocationButton_Click(object sender, EventArgs e)
        {
            //Start the stopwatch to see how long reading takes
            watch.Start();

            //Uses ISS class to find where the ISS is and set information on that
            ISSLocation.setISSLocation();
            string overWater = "";
            var locationData = "";
            var seconds = 0.0;

            //Finds distance in miles with decimal values of lat and long from current Location and ISS location
            double distance = GeoCalculator.GetDistance(CurrentLocation.currentDLat, CurrentLocation.currentDLong, ISSLocation.ISSDLat, ISSLocation.ISSDLong);
         
            if (ISSLocation.bodyOfWater)
            {
                overWater = $"The ISS is currently over water.\r\n";
            }
            else
            {
                overWater = $"ISS country: {ISSLocation.ISSCountry}\r\n";

            }

            locationData = $"Your chosen zip: {CurrentLocation.currentZip}\r\n" +
                           $"Your chosen location: {CurrentLocation.currentCity}\r\n" +
                           $"Your chosen state: {CurrentLocation.currentState}\r\n" +
                           $"Distance from ISS: {distance} miles\r\n" +
                           overWater +
                           $"Time pinpointed: {ISSLocation.timeAccessed}\r\n";

            mainContentTxtBox.Text = locationData;

            //sets stopwatch textbox to show fast it did it in
            watch.Stop();
            TimeSpan ts = watch.Elapsed;
            seconds = ts.Milliseconds / 1000.0;
            stopWatchTxtBox.Text = $"Reading Taken in {seconds} Second(s)!";

            SerializeData.save(locationData); //Saves after every click
        }

        private void viewPastDataButton_Click(object sender, EventArgs e)
        {
            mainContentTxtBox.Text = SerializeData.read();
        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image myImage = Properties.Resources.SpaceBackground;
            this.BackgroundImage = myImage;
            mainContentTxtBox.BackColor = Color.Black;
            mainContentTxtBox.ForeColor = Color.White;

            directionsTxtBox.BackColor = Color.Black;
            directionsTxtBox.ForeColor = Color.White;

            currentLocationTxtBox.BackColor = Color.Black;
            currentLocationTxtBox.ForeColor = Color.White;

            pastDataTxtBox.BackColor = Color.Black;
            pastDataTxtBox.ForeColor = Color.White;

            stopWatchTxtBox.BackColor = Color.Black;
            stopWatchTxtBox.ForeColor = Color.White;

        }

        private void normalModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.BackColor = Color.White;
            mainContentTxtBox.BackColor = Color.White;
            mainContentTxtBox.ForeColor = Color.Black;

            directionsTxtBox.BackColor = Color.White;
            directionsTxtBox.ForeColor = Color.Black;

            pastDataTxtBox.BackColor = Color.White;
            pastDataTxtBox.ForeColor = Color.Black;

            currentLocationTxtBox.BackColor = Color.White;
            currentLocationTxtBox.ForeColor = Color.Black;

            stopWatchTxtBox.BackColor = Color.White;
            stopWatchTxtBox.ForeColor = Color.Black;
        }

        private void clearLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerializeData.clearLogs();
        }
    }
}
