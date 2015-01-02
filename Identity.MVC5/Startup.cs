using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Identity.MVC5.Startup))]
namespace Identity.MVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
