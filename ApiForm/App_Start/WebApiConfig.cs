using ApiForm.Models;
using ApiForm.Models.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ApiForm
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Конфигурация и службы веб-API

            // Маршруты веб-API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "SomeRoute",
                routeTemplate: "api/{controller}/{action}"
            );

            //config.Routes.MapHttpRoute(
            //    name: "setdata",
            //    routeTemplate: "api/{controller}/{data}",
            //    defaults: 
            //    new {
            //        data = new Data
            //        (
            //            new Dictionary<string, object>()
            //            {
            //                { "Hello" , "World" },
            //                {"Number is", 123 }
            //            }
            //        )
            //    }
            //);

            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.Formatters.Add(new DataFormatter());
        }
    }
}
