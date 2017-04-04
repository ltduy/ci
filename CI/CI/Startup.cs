using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CI.Startup))]
namespace CI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
