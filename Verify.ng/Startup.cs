using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Verify.ng.Startup))]
namespace Verify.ng
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
