using System.Web;
using System.Web.Mvc;

namespace LamVinhLoc_2011064018_THWEB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
