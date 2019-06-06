using Geolocation;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISSLocation2
{
    public partial class Form1 : Form
    {
        WebClient wc = new WebClient();

        public Form1()
        {
            InitializeComponent();
            CurrentLocation.setLocation();                //Up here so it sets your current location and displays it in the box since this method will only need to run once
            textBox1.Text = CurrentLocation.currentZip;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            wc.DownloadFile(@"https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQgC1bwfmGkLVM3fXIYOTVJ5isWkh2piaNmJ1Lr5_tq8jC4iL1t", @"c:\Intel\ISS.png");
            Image picBox = new Bitmap(@"c:\Intel\ISS.png");
            pictureBox1.Image = picBox;           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Uses ISS class to find where the ISS is and set information on that
            ISSLocation.setISSLocation();

            var locationData = "";

            //Finds distance in miles with decimal values of lat and long from current Location and ISS location
            double distance = GeoCalculator.GetDistance(CurrentLocation.currentDLat, CurrentLocation.currentDLong, ISSLocation.ISSDLat, ISSLocation.ISSDLong);

            if (ISSLocation.bodyOfWater)  //Theres definitley a better way to structure this
            {
                locationData = $"Your chosen zip: {CurrentLocation.currentZip}\r\n" +
                                $"Your chosen location: {CurrentLocation.currentCity}\r\n" +
                                $"Your chosen state: {CurrentLocation.currentState}\r\n" +
                                $"Distance from ISS: {distance} miles\r\n" +
                                $"The ISS is currently over water.\r\n" +
                                $"Time pinpointed: {ISSLocation.timeAccessed}\r\n";
            }
            else
            {
                locationData = $"Your chosen zip: {CurrentLocation.currentZip}\r\n" +
                                $"Your chosen location: {CurrentLocation.currentCity}\r\n" +
                                $"Your chosen state: {CurrentLocation.currentState}\r\n" +
                                $"Distance from ISS: {distance} miles\r\n" +
                                $"ISS country: {ISSLocation.ISSCountry}\r\n" +
                                $"Time pinpointed: {ISSLocation.timeAccessed}\r\n";
            }
            textBox2.Text = locationData;
            SerializeData.serializeData(locationData); //Saves after every click
        } 

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wc.DownloadFile(@"https://wallpapercave.com/wp/saiUfL2.png", @"c:\Intel\image.png");
            Image myImage = new Bitmap(@"c:\Intel\image.png");
            this.BackgroundImage = myImage;
            textBox2.BackColor = Color.Black;
            textBox2.ForeColor = Color.White;

            textBox3.BackColor = Color.Black;
            textBox3.ForeColor = Color.White;

            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.White;

            textBox4.BackColor = Color.Black;
            textBox4.ForeColor = Color.White;

            //menuStrip1.BackColor = Color.Black;
            //menuStrip1.ForeColor = Color.White;           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void normalModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            this.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.Black;

            textBox3.BackColor = Color.White;
            textBox3.ForeColor = Color.Black;

            textBox4.BackColor = Color.White;
            textBox4.ForeColor = Color.Black;

            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
        
            //menuStrip1.BackColor = Color.White;
            //menuStrip1.ForeColor = Color.Black;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = SerializeData.deserializeData();
        }

        private void clearLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerializeData.clearLogs();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
