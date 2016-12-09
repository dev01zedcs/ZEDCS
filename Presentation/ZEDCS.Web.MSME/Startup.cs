using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZEDCS.Web.MSME.Startup))]
namespace ZEDCS.Web.MSME
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
