using System.Web;
using System.Web.Mvc;
using MyHR.Library.ActionFilter;

namespace MyHR
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ActionLogFilter());
        }
    }
}
