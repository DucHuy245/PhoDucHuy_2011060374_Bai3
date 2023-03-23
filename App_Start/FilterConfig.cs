using System.Web;
using System.Web.Mvc;

namespace PhoDucHuy_2011060374_Bai3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
