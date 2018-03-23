using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCGitHub.Startup))]
namespace MVCGitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
