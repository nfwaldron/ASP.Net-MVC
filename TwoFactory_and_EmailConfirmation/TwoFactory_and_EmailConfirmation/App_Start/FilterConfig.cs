using System.Web;
using System.Web.Mvc;

namespace TwoFactory_and_EmailConfirmation
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
