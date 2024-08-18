using System.Web;
using System.Web.Mvc;

namespace Examen01MVC_CesarJuñoFuentes
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
