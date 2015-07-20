using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlbumApplication.Startup))]
namespace AlbumApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
