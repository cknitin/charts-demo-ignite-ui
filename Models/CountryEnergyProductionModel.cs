using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace charts_demo_ignite_ui.Models
{
    public class CountryEnergyProductionModel
    {
        public int Year { get; set; }
        public double Canada { get; set; }
        public double SaudiArabia { get; set; }
        public double Russia { get; set; }
        public double UnitedStates { get; set; }
        public double China { get; set; }


        public string GetCountriesEnergyProductionInJosn()
        {
            List<CountryEnergyProductionModel> data = new List<CountryEnergyProductionModel>();

            CountryEnergyProductionModel year1 = new CountryEnergyProductionModel();
            year1.Year = 2005;
            year1.Canada = 18.8932;
            year1.SaudiArabia = 25.4401;
            year1.Russia = 51.0796;
            year1.UnitedStates = 69.4437;
            year1.China = 63.9524;
            data.Add(year1);

            CountryEnergyProductionModel year2 = new CountryEnergyProductionModel();
            year2.Year = 2006;
            year2.Canada = 19.2273;
            year2.SaudiArabia = 24.6105;
            year2.Russia = 52.0557;
            year2.UnitedStates = 70.7539;
            year2.China = 68.2333;
            data.Add(year2);


            CountryEnergyProductionModel year3 = new CountryEnergyProductionModel();
            year3.Year = 2007;
            year3.Canada = 19.5439;
            year3.SaudiArabia = 23.7326;
            year3.Russia = 52.5599;
            year3.UnitedStates = 71.4000;
            year3.China = 73.2809;
            data.Add(year3);


            CountryEnergyProductionModel year4 = new CountryEnergyProductionModel();
            year4.Year = 2008;
            year4.Canada = 19.0196;
            year4.SaudiArabia = 25.1682;
            year4.Russia = 52.5460;
            year4.UnitedStates = 73.2178;
            year4.China = 78.3599;
            data.Add(year4);

            CountryEnergyProductionModel year5 = new CountryEnergyProductionModel();
            year5.Year = 2009;
            year5.Canada = 18.3249;
            year5.SaudiArabia = 22.837;
            year5.Russia = 50.4291;
            year5.UnitedStates = 72.6409;
            year5.China = 84.0643;
            data.Add(year5);


            var json = new JavaScriptSerializer().Serialize(data);
            return json;
        }
    }

}