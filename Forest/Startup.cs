using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Forest.Startup))]
namespace Forest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
