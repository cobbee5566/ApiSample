using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApiSample.UI.WebSite.Startup))]
namespace ApiSample.UI.WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
