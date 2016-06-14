using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Benny.Web.Startup))]
namespace Benny.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
