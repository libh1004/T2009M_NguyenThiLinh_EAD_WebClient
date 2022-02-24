using System.Web;
using System.Web.Mvc;

namespace T2009M_NguyenThiLinh_EAD_WebClient
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
