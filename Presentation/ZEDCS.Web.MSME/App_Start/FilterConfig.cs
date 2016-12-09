using System.Web;
using System.Web.Mvc;

namespace ZEDCS.Web.MSME
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
