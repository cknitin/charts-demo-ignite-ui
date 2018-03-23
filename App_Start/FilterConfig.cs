using System.Web;
using System.Web.Mvc;

namespace charts_demo_ignite_ui
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
