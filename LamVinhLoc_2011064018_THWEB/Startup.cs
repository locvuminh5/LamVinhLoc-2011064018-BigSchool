using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LamVinhLoc_2011064018_THWEB.Startup))]
namespace LamVinhLoc_2011064018_THWEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
