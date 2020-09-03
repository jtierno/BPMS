using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BPMS.WebUI.Startup))]
namespace BPMS.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
