using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoPlaySC.Startup))]
namespace CoPlaySC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
