using System.Web;
using System.Web.Mvc;

namespace ONESOFT.EntregaOnline.Interface
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}