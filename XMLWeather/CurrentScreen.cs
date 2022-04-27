using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Form1.days[0].currentTemp;
            minOutput.Text = Form1.days[0].tempLow;
            maxOutput.Text = Form1.days[0].tempHigh;
            datetext.Text = Form1.days[0].date;
            int conditionCode = Convert.ToInt32(Form1.days[0].condition);

            if (conditionCode > 300 && conditionCode < 600)
            {
                picture.BackgroundImage = Properties.Resources.weather9;

            }

            if (conditionCode > 800 && conditionCode < 900)
            {
                picture.BackgroundImage = Properties.Resources.weather0;

            }

            if (conditionCode > 200 && conditionCode < 232)
            {
                picture.BackgroundImage = Properties.Resources.weather3;

            }

            if (conditionCode > 600 && conditionCode < 622)
            {
                picture.BackgroundImage = Properties.Resources.weather10;

            }

            if (conditionCode > 700 && conditionCode < 761)
            {
                picture.BackgroundImage = Properties.Resources.weather8;

            }
            if (conditionCode == 781)
            {
                picture.BackgroundImage = Properties.Resources.weather11;

            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void minLabel_Click(object sender, EventArgs e)
        {

        }

        private void maxOutput_Click(object sender, EventArgs e)
        {

        }
    }
}

       

        
    

