using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RH___LW.Startup))]
namespace RH___LW
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
