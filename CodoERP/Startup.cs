using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodoERP.Startup))]
namespace CodoERP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
