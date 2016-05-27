using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CompanyGUI.Startup))]
namespace CompanyGUI
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
