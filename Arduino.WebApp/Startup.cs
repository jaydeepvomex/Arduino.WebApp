using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Arduino.WebApp.Startup))]
namespace Arduino.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
