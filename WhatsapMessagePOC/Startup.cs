using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WhatsapMessagePOC.Startup))]
namespace WhatsapMessagePOC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
