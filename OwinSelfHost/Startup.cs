using Microsoft.Owin.StaticFiles;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwinSelfHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.Run(obj =>
            //{
            //    obj.Response.ContentType = "text/plain";
            //    return obj.Response.WriteAsync("Hello from OWIN");
            //});

            // app.UseStaticFiles("/Web");

            //var config = new HttpConfiguration();
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            // app.UseWebApi(config);
            app.UseFileServer(true);
        }
    }
}
