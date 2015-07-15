using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToyStoreApplication.Startup))]
namespace ToyStoreApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
