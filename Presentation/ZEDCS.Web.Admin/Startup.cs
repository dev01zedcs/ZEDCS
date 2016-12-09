using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZEDCS.Web.Admin.Startup))]
namespace ZEDCS.Web.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
