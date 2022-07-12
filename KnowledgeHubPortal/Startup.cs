using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KnowledgeHubPortal.Startup))]
namespace KnowledgeHubPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
