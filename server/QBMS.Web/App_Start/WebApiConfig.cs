using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;

namespace QBMS.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //  config.EnableCors(GetCorsAttribute());
        }

        private static EnableCorsAttribute GetCorsAttribute()
        {
            const string origins = "*";
            const string headers = "Origin, X-Requested-With, Content-Type, Accept, Authorization";
            const string methods = "GET,POST,OPTIONS,PUT";

            return new EnableCorsAttribute(origins, headers, methods)
            {
                SupportsCredentials = true
            };
        }
    }
}
