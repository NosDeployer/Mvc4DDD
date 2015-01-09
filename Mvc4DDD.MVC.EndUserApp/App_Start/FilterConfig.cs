using System.Web;
using System.Web.Mvc;

namespace Mvc4DDD.MVC.EndUserApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}