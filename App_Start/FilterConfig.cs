using System.Web;
using System.Web.Mvc;

namespace Studio.Vision.POS.Telko.WebApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
