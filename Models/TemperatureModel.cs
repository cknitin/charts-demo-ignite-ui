using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace charts_demo_ignite_ui.Models
{
    public class CityTemperatureModel
    {
        public dynamic Date { get; set; }
        public string Time { get; set; }
        public double NewYorkCityTemp { get; set; }
        public double PhiladelphiaTemp { get; set; }


        public string GetCountriesTemperatureInJson()
        {
            List<CityTemperatureModel> countries = new List<CityTemperatureModel>();

            CityTemperatureModel country1 = new CityTemperatureModel();
            country1.Date= "2013-07-16";
            country1.Time="1:00";
            country1.NewYorkCityTemp=85.46;
            country1.PhiladelphiaTemp=86.72;
            countries.Add(country1);

            CityTemperatureModel country2 = new CityTemperatureModel();
            country2.Date="2013-07-16";
            country2.Time="3:00";
            country2.NewYorkCityTemp=82.76;
            country2.PhiladelphiaTemp=84.74;
            countries.Add(country2);

            CityTemperatureModel country3 = new CityTemperatureModel();
            country3.Date="2013-07-16";
            country3.Time="5:00";
            country3.NewYorkCityTemp=80.6;
            country3.PhiladelphiaTemp=82.94;
            countries.Add(country3);

            CityTemperatureModel country4 = new CityTemperatureModel();
            country4.Date="2013-07-16";
            country4.Time="7:00";
            country4.NewYorkCityTemp=79.34;
            country4.PhiladelphiaTemp = 82.22;
            countries.Add(country4);

            CityTemperatureModel country5 = new CityTemperatureModel();
            country5.Date="2013-07-16";
            country5.Time="9:00";
            country5.NewYorkCityTemp=82.76;
            country5.PhiladelphiaTemp = 86;
            countries.Add(country5);

            CityTemperatureModel country6 = new CityTemperatureModel();
            country6.Date="2013-07-16";
            country6.Time="11:00";
            country6.NewYorkCityTemp=86.54;
            country6.PhiladelphiaTemp= 88.88;
            countries.Add(country6);

            CityTemperatureModel country7 = new CityTemperatureModel();
            country7.Date="2013-07-16";
            country7.Time="13:00";
            country7.NewYorkCityTemp=89.78;
            country7.PhiladelphiaTemp = 93.38;
            countries.Add(country7);

            CityTemperatureModel country8 = new CityTemperatureModel();
            country8.Date="2013-07-16";
            country8.Time="15:00";
            country8.NewYorkCityTemp=92.48;
            country8.PhiladelphiaTemp= 93.2;
            countries.Add(country8);

            CityTemperatureModel country9 = new CityTemperatureModel();
            country9.Date="2013-07-16";
            country9.Time="17:00";
            country9.NewYorkCityTemp=93.2;
            country9.PhiladelphiaTemp = 92.3;
            countries.Add(country9);

            CityTemperatureModel country10 = new CityTemperatureModel();
            country10.Date="2013-07-16";
            country10.Time="19:00";
            country10.NewYorkCityTemp=91.4;
            country10.PhiladelphiaTemp= 92.48;
            countries.Add(country10);

            CityTemperatureModel country11 = new CityTemperatureModel();
            country11.Date="2013-07-16";
            country11.Time="21:00";
            country11.NewYorkCityTemp=88.52;
            country11.PhiladelphiaTemp= 89.78;
            countries.Add(country11);

            CityTemperatureModel country12 = new CityTemperatureModel();
            country12.Date="2013-07-16";
            country12.Time="23:00";
            country12.NewYorkCityTemp=88.16;
            country12.PhiladelphiaTemp = 86.72;
            countries.Add(country12);


            var json = new JavaScriptSerializer().Serialize(countries);

            return json;
        }

    }
}