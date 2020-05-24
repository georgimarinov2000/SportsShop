using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportsShop.Startup))]
namespace SportsShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
