using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KontrolProject.Startup))]
namespace KontrolProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
