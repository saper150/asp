using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hacked.Startup))]
namespace hacked
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
