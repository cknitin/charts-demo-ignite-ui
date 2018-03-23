using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace charts_demo_ignite_ui.Models
{
    /// <summary>
    /// This will represent the chaet
    /// </summary>
    public class Chart
    {
        /// <summary>
        /// Every chart has a Id like 1, 2, 3 so on
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        ///  CategoryId will hold the Id of parent chart to maintain Category and sub category relationship
        /// </summary>
        public int CategoryId { get; set; }
        /// <summary>
        /// Name of the Chart
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// To hold the data for a chart
        /// </summary>
        public dynamic Data { get; set; }
    }

    /// <summary>
    /// This class will represent the List of charts with main and sub subcategories
    /// </summary>
    public class Charts
    {
        /// <summary>
        /// This is main category of chart
        /// </summary>
        public Chart Category { get; set; }
        /// <summary>
        /// This will hold the subcategories of this main chart
        /// </summary>
        public List<Chart> SubCategory { get; set; }
    }
}