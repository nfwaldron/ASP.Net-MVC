using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ManageContacts.Startup))]
namespace ManageContacts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
