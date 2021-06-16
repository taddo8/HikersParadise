using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HikersParadise.Startup))]
namespace HikersParadise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
