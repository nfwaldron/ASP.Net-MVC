using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCRazor.Startup))]
namespace MVCRazor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
