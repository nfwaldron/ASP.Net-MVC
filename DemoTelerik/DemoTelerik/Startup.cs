using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoTelerik.Startup))]
namespace DemoTelerik
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
