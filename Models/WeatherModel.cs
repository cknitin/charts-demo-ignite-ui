using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace charts_demo_ignite_ui.Models
{
    public class WeatherModel
    {
        public int id { get; set; }
        public dynamic Date { get; set; }
        public string Time { get; set; }
        public double WindSpeed { get; set; }
        public double WindDirection { get; set; }

        public string GetCountriesTemperatureInJson()
        {
            List<WeatherModel> weatherReport = new List<WeatherModel>();

            WeatherModel weather1 = new WeatherModel();
            weather1.id = 0;
            weather1.Date = "2013-07-16";
            weather1.Time = "10:00";
            weather1.WindSpeed = 3.305;
            weather1.WindDirection = 141;
            weatherReport.Add(weather1);

            WeatherModel weather2 = new WeatherModel();
            weather2.id = 1;
            weather2.Date = "2013-07-16";
            weather2.Time = "11:00";
            weather2.WindSpeed = 5.832;
            weather2.WindDirection = 181;
            weatherReport.Add(weather2);

            WeatherModel weather3 = new WeatherModel();
            weather3.id = 2;
            weather3.Date = "2013-07-16";
            weather3.Time = "12:00";
            weather3.WindSpeed = 5.637;
            weather3.WindDirection = 179;
            weatherReport.Add(weather3);

            WeatherModel weather4 = new WeatherModel();
            weather4.id = 3;
            weather4.Date = "2013-07-16";
            weather4.Time = "13:00";
            weather4.WindSpeed = 8.747;
            weather4.WindDirection = 196;
            weatherReport.Add(weather4);

            WeatherModel weather5 = new WeatherModel();
            weather5.id = 4;
            weather5.Date = "2013-07-16";
            weather5.Time = "14:00";
            weather5.WindSpeed = 8.553;
            weather5.WindDirection = 208;
            weatherReport.Add(weather5);

            WeatherModel weather6 = new WeatherModel();
            weather6.id = 5;
            weather6.Date = "2013-07-16";
            weather6.Time = "15:00";
            weather6.WindSpeed = 7.581;
            weather6.WindDirection = 207;
            weatherReport.Add(weather6);

            WeatherModel weather7 = new WeatherModel();
            weather7.id = 6;
            weather7.Date = "2013-07-16";
            weather7.Time = "16:00";
            weather7.WindSpeed = 7.775;
            weather7.WindDirection = 211;
            weatherReport.Add(weather7);

            WeatherModel weather8 = new WeatherModel();
            weather8.id = 7;
            weather8.Date = "2013-07-16";
            weather8.Time = "17:00";
            weather8.WindSpeed = 6.026;
            weather8.WindDirection = 214;
            weatherReport.Add(weather8);

            WeatherModel weather9 = new WeatherModel();
            weather9.id = 8;
            weather9.Date = "2013-07-16";
            weather9.Time = "18:00";
            weather9.WindSpeed = 6.803;
            weather9.WindDirection = 208;
            weatherReport.Add(weather9);

            WeatherModel weather10 = new WeatherModel();
            weather10.id = 9;
            weather10.Date = "2013-07-16";
            weather10.Time = "19:00";
            weather10.WindSpeed = 0.583;
            weather10.WindDirection = 236;
            weatherReport.Add(weather10);

            WeatherModel weather11 = new WeatherModel();
            weather11.id = 10;
            weather11.Date = "2013-07-16";
            weather11.Time = "20:00";
            weather11.WindSpeed = 6.609;
            weather11.WindDirection = 307;
            weatherReport.Add(weather11);

            WeatherModel weather12 = new WeatherModel();
            weather12.id = 10;
            weather12.Date = "2013-07-16";
            weather12.Time = "21:00";
            weather12.WindSpeed = 0.000;
            weather12.WindDirection = 357;
            weatherReport.Add(weather12);


            var json = new JavaScriptSerializer().Serialize(weatherReport);

            return json;
        }

    }
}