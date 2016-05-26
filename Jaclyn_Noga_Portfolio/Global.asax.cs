using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Jaclyn_Noga_Portfolio.Models;
using System.Data.Entity;

namespace Jaclyn_Noga_Portfolio
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer<Jaclyn_Noga_PortfolioContext>(new DropCreateDatabaseIfModelChanges<Jaclyn_Noga_PortfolioContext>());
        }
    }
}
