using SistemaA.Classes;
using System;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SistemaA
{

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Models.SistemaAContext, Migrations.Configuration>());
            CheckRoleAndSuperUser();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

              private void CheckRoleAndSuperUser()
        {
            UserHelper.UsersHelper.CheckRole("Admin");
            UserHelper.UsersHelper.CheckSuperUser("admin@admin.com");
          
        }
    }
}

    