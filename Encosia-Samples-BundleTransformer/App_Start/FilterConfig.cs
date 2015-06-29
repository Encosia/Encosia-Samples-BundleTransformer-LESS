using System.Web;
using System.Web.Mvc;

namespace Encosia_Samples_BundleTransformer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
