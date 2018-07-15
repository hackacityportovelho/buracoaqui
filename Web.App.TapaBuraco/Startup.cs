using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.App.TapaBuraco.Startup))]
namespace Web.App.TapaBuraco
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
