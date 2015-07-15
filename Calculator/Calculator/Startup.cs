using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalculatorForm.Startup))]
namespace CalculatorForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
