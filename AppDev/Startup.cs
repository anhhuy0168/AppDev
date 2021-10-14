using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppDev.Startup))]
namespace AppDev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
