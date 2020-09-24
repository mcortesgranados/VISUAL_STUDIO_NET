using System.Web;
using System.Web.Mvc;

namespace PRUEBA_TECNICA_SEIDOR_ACGR_Proyecto
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
