using System.Web;
using System.Web.Mvc;

namespace _1911065208_CaoVanHau
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
