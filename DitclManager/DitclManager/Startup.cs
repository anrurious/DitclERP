using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DitclManager.Startup))]
namespace DitclManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
