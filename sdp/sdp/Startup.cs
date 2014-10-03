using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SDP.Startup))]
namespace SDP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
