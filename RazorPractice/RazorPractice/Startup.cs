using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RazorPractice.Startup))]
namespace RazorPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
