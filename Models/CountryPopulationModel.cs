using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace charts_demo_ignite_ui.Models
{
    public class CountryPopulationModel
    {
        public string CountryName { get; set; }
        public int Pop1995 { get; set; }
        public int Pop2005 { get; set; }


        public string GetCountriesPopulationInJson()
        {
            List<CountryPopulationModel> countries = new List<CountryPopulationModel>();

            CountryPopulationModel country1 = new CountryPopulationModel();
            country1.CountryName = "China";
            country1.Pop1995 = 1216;
            country1.Pop2005 = 1216;
            countries.Add(country1);

            CountryPopulationModel country2 = new CountryPopulationModel();
            country2.CountryName = "India";
            country2.Pop1995= 920;
            country2.Pop2005= 1090;
            countries.Add(country2);

            CountryPopulationModel country3 = new CountryPopulationModel();
            country3.CountryName = "United States";
            country3.Pop1995 = 266;
            country3.Pop2005 = 295;
            countries.Add(country3);

            CountryPopulationModel country4 = new CountryPopulationModel();
            country4.CountryName = "Indonesia";
            country4.Pop1995 = 197;
            country4.Pop2005 = 229;
            countries.Add(country4);

            CountryPopulationModel country5 = new CountryPopulationModel();
            country5.CountryName = "Brazil";
            country5.Pop1995 = 161;
            country5.Pop2005 = 186;
            countries.Add(country5);

            var json = new JavaScriptSerializer().Serialize(countries);

            return json;
        }
       

    }
}