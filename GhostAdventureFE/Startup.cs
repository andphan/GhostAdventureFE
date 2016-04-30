using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GhostAdventureFE.Startup))]
namespace GhostAdventureFE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
