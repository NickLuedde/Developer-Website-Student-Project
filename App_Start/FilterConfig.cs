using System.Web;
using System.Web.Mvc;

namespace NicholasLuedde_DotNetDeveloper
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
