﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
      public static  List<Day>days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        private void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=Stratford,CA&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //TODO: create a day object
                Day newDay = new Day();

                //TODO: fill day object with required data
                reader.ReadToFollowing("time");
               newDay.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                newDay.condition = reader.GetAttribute("number");

                reader.ReadToFollowing("temperature");
                newDay.tempLow = reader.GetAttribute("min");
                newDay.tempHigh = reader.GetAttribute("max");

             //   reader.ReadToFollowing("date");
              //  newDay.date = reader.GetAttribute("name");

                //TODO: if day object not null add to the days list
                if(newDay.date != null)
                {
                    days.Add(newDay);

                }
                
            }
        }

        private void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it

            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("speed");
            days[0].windSpeed = reader.GetAttribute("value");

            reader.ReadToFollowing("direction");
            days[0].windDirection = reader.GetAttribute("code");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");

          
            
            reader.ReadToFollowing("lastupdate");
            days[0].location = reader.GetAttribute("value");


            //TODO: find the city and current temperature and add to appropriate item in days list

        }


    }
}
