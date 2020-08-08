using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Cerveza.DataAccessLogic.DB;

namespace CervezaWebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            //Init Custom DB
            UsersTable.InitUsersTable();
            BeersTable.InitBeersTable();
            User_x_BeerTable.InitUser_x_BeerTable();
            // Configuración y servicios de API web

            // Rutas de API web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "CustomActions",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
