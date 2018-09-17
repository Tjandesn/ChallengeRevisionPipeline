using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OAuthRevision.Startup))]
namespace OAuthRevision
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
