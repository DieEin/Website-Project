using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebsiteProject.Startup))]
namespace WebsiteProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
