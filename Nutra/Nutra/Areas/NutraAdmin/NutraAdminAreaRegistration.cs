using System.Web.Mvc;

namespace Nutra.Areas.NutraAdmin
{
    public class NutraAdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "NutraAdmin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "NutraAdmin_default",
                "NutraAdmin/{controller}/{action}/{id}",
                new { controller = "Home" , action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
