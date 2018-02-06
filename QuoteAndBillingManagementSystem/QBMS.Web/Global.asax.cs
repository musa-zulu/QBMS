using System.Configuration;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Castle.Windsor;
using QBMS.DB.Migrations;
using QBMS.Web.Bootstrappers;

namespace QBMS.Web
{
    public class WebApiApplication : HttpApplication
    {
        private static IWindsorContainer _container = new WindsorContainer();

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var connectionString = GetConnectionString();
            MigrateDatabaseWith(connectionString);
            BootstrapContainer();
        }

        protected void Application_End()
        {
            if (_container != null) _container.Dispose();
        }

        private static void BootstrapContainer()
        {
            _container = new WindsorBootstrapper().Boostrap();
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["QBMS"].ToString();
        }

        private void MigrateDatabaseWith(string connectionString)
        {
            var runner = new Migrator(connectionString);
            runner.MigrateToLatest();
        }
    }
}
