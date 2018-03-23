using charts_demo_ignite_ui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace charts_demo_ignite_ui.Controllers
{
    public class ChartsController : Controller
    {
        /// <summary>
        /// This will hold list of charts
        /// </summary>
        public List<Charts> Charts { get; set; }

        /// <summary>
        /// Constructor to initilize the charts property
        /// </summary>
        public ChartsController()
        {
            Charts = LoadCharts();
        }

        // GET: BusinessChart
        public ActionResult Index()
        {
            List<SelectListItem> Charts = new List<SelectListItem>();
            var CategorysCharts = (from chart in this.Charts select chart.Category).ToList();

            foreach (var chart in CategorysCharts)
            {
                Charts.Add(new SelectListItem { Value = chart.Id.ToString(), Text = chart.Name });
            }

            ViewData["CategoryCharts"] = Charts;
            ViewData["SubCategoryCharts"] = new List<SelectListItem>();
            return View();
        }

        public ActionResult RenderChart(string name)
        {
            string data = string.Empty;
            CountryPopulationModel countryPopulation = new CountryPopulationModel();
            CityTemperatureModel cityTemperature = new CityTemperatureModel();
            CountryEnergyProductionModel countryEnergy = new CountryEnergyProductionModel();
            WeatherModel weather = new WeatherModel();

            switch (name)
            {
                case "Stacked Area":
                case "Stacked Bar":
                case "Stacked Column":
                case "Stacked Line":
                case "Stacked Spline":
                case "Stacked Spline Area":
                case "100% Stacked Area":
                case "100% Stacked Bar":
                case "100% Stacked Column":
                case "100% Stacked Line":
                case "100% Stacked Spline":
                case "100% Stacked Spline Area":
                case "Bar":
                case "Column":
                case "Line":
                case "Point":
               
                    data = countryEnergy.GetCountriesEnergyProductionInJosn();
                    break;

                case "Radial Area":
                case "Radial Column":
                case "Radial Line":
                case "Radial Pie":

                case "Range Area":
                case "Range Column":
                    data = cityTemperature.GetCountriesTemperatureInJson();
                    break;

                case "Spline":
                case "Spline Area":
                case "Step Area":
                case "Step Line":
                case "Waterfall":
                case "Doughnut":
                case "Pie":
                    data = countryPopulation.GetCountriesPopulationInJson();
                    break;

                case "Polar Area":
                case "Polar Line":
                case "Polar Point":
                case "Polar Spline":
                case "Polar Spline Area":
                    data = weather.GetCountriesTemperatureInJson();
                    break;


                default:
                    break;
            }


            return PartialView("_RenderChart", new charts_demo_ignite_ui.Models.Chart { Name = name, Data = data });
        }

        [HttpPost]
        public ActionResult GetSubCategoryCharts(string CategoryChartId)
        {
            int pId;
            List<Chart> charts = new List<Chart>();
            if (!string.IsNullOrEmpty(CategoryChartId))
            {
                pId = Convert.ToInt32(CategoryChartId);
                List<Chart> SubCategoryCharts = (from chart in Charts where chart.Category.Id == pId select chart.SubCategory).FirstOrDefault();
                SubCategoryCharts.ForEach(x =>
                {
                    charts.Add(new Chart { Id = x.Id, Name = x.Name, CategoryId = x.CategoryId });
                });
            }
            return Json(charts, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// This Method will add all the charts
        /// </summary>
        /// <returns></returns>
        public List<Charts> LoadCharts()
        {
            return Charts = new List<Charts>()
            {
                new Charts
                {
                    Category = new Chart { Id = 1, CategoryId = 0, Name = "Business Chart" },
                    SubCategory = new List<Chart>
                    {
                        new Chart { Id = 1, CategoryId =1, Name = "Bar"  },
                        new Chart { Id = 2, CategoryId =1, Name = "Bubble"  },
                        new Chart { Id = 3, CategoryId =1, Name = "Column"  },
                        new Chart { Id = 4, CategoryId =1, Name = "Doughnut" },
                        new Chart { Id = 5, CategoryId =1, Name = "Financial"  },
                        new Chart { Id = 6, CategoryId =1, Name = "Funnel"  },
                        new Chart { Id = 7, CategoryId =1, Name = "Line"  },
                        new Chart { Id = 8, CategoryId =1, Name = "Pie" },
                        new Chart { Id = 8, CategoryId =1, Name = "Point" },
                        new Chart { Id = 8, CategoryId =1, Name = "Scatter" },
                        new Chart { Id = 8, CategoryId =1, Name = "Sparkline" }

                    }
                },
                new Charts
                {
                    Category = new Chart { Id = 2, CategoryId = 0, Name = "Polar Chart" },
                    SubCategory = new List<Chart>
                    {
                        new Chart { Id = 1, CategoryId =2, Name = "Polar Area"  },
                        new Chart { Id = 2, CategoryId =2, Name = "Polar Line"  },
                        new Chart { Id = 3, CategoryId =2, Name = "Polar Point"  },
                        new Chart { Id = 4, CategoryId =2, Name = "Polar Spline" },
                        new Chart { Id = 5, CategoryId =2, Name = "Polar Spline Area"  }
                    }
                },

                new Charts
                {
                    Category = new Chart { Id = 3, CategoryId = 0, Name = "Radial Chart" },
                    SubCategory = new List<Chart>
                    {
                        new Chart { Id = 1, CategoryId =3, Name = "Radial Area"  },
                        new Chart { Id = 2, CategoryId =3, Name = "Radial Line"  },
                        new Chart { Id = 3, CategoryId =3, Name = "Radial Column"  },
                        new Chart { Id = 4, CategoryId =3, Name = "Radial Pie" }
                    }
                },
                new Charts
                {
                    Category = new Chart { Id = 4, CategoryId = 0, Name = "Range Chart" },
                    SubCategory = new List<Chart>
                    {
                        new Chart { Id = 1, CategoryId =4, Name = "Range Area"  },
                        new Chart { Id = 2, CategoryId =4, Name = "Range Column"  }

                    }
                },
                new Charts
                {
                    Category = new Chart { Id = 5, CategoryId = 0, Name = "Spline Chart" },
                    SubCategory = new List<Chart>
                    {
                        new Chart { Id = 1, CategoryId =5, Name = "Spline"  },
                        new Chart { Id = 2, CategoryId =5, Name = "Spline Area"  }

                    }
                },
                new Charts
                {
                    Category = new Chart { Id = 6, CategoryId = 0, Name = "Stacked Chart" },
                    SubCategory = new List<Chart>
                    {
                        new Chart { Id = 1, CategoryId =6, Name = "Stacked Area"  },
                        new Chart { Id = 2, CategoryId =6, Name = "Stacked Bar"  },
                        new Chart { Id = 3, CategoryId =6, Name = "Stacked Column"  },
                        new Chart { Id = 4, CategoryId =6, Name = "Stacked Line"  },
                        new Chart { Id = 5, CategoryId =6, Name = "Stacked Spline"  },
                        new Chart { Id = 6, CategoryId =6, Name = "Stacked Spline Area"  },
                        new Chart { Id = 7, CategoryId =6, Name = "100% Stacked Area"  },
                        new Chart { Id = 8, CategoryId =6, Name = "100% Stacked Bar" },
                        new Chart { Id = 9, CategoryId =6, Name = "100% Stacked Column" },
                        new Chart { Id = 10, CategoryId =6, Name = "100% Stacked Line" },
                        new Chart { Id = 11, CategoryId =6, Name = "100% Stacked Spline" },
                        new Chart { Id = 12, CategoryId =6, Name = "100% Stacked Spline Area" }
                    }
                },
                new Charts
                {
                    Category = new Chart { Id = 7, CategoryId = 0, Name = "Step Chart" },
                    SubCategory = new List<Chart>
                    {
                        new Chart { Id = 1, CategoryId =7, Name = "Step Area"  },
                        new Chart { Id = 2, CategoryId =7, Name = "Step Line"  },
                        new Chart { Id = 3, CategoryId =7, Name = "Waterfall"  }

                    }
                },
                new Charts
                {
                    Category = new Chart { Id = 8, CategoryId = 0, Name = "Shape Chart" },
                    SubCategory = new List<Chart>
                    {
                        new Chart { Id = 1, CategoryId =7, Name = "Binding Break Event Data"  },
                        new Chart { Id = 2, CategoryId =7, Name = "Polygon"  },
                        new Chart { Id = 3, CategoryId =7, Name = "Polyline"  }

                    }
                }


            };
        }
    }
}