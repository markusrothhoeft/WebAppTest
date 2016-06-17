using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace webapptest.app.mvcapi
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

// Einrichten einer ProviderFactorie für die Verwendung von Json.Net als Deserialisierer bei Request an MVC Controller

            //ValueProviderFactories.Factories.Remove(ValueProviderFactories.Factories.OfType<JsonValueProviderFactory>().FirstOrDefault());
            //ValueProviderFactories.Factories.Add(new JsonNetValueProviderFactory());

            //var defaultJsonFactory = ValueProviderFactories.Factories.OfType<JsonValueProviderFactory>().FirstOrDefault();
            //var index = ValueProviderFactories.Factories.IndexOf(defaultJsonFactory);
            //ValueProviderFactories.Factories.Remove(defaultJsonFactory);
            //ValueProviderFactories.Factories.Insert(index, new JsonNetValueProviderFactory());

        }
    }
}
