using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwoFactory_and_EmailConfirmation.Startup))]
namespace TwoFactory_and_EmailConfirmation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
