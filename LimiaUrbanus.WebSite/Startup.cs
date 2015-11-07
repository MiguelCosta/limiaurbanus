using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LimiaUrbanus.WebSite.Startup))]
namespace LimiaUrbanus.WebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
