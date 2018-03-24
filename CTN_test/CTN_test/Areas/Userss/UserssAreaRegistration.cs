using System.Web.Mvc;

namespace CTN_test.Areas.Userss
{
    public class UserssAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Userss";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Userss_default",
                "Userss/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}