using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WritingRealm.Web.Startup))]
namespace WritingRealm.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
