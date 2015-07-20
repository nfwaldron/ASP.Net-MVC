using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Strongly_Typed_Views.Startup))]
namespace Strongly_Typed_Views
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
