using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdDataSite.Startup))]
namespace AdDataSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
