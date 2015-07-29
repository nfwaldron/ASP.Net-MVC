using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureApplication.Startup))]
namespace AzureApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
