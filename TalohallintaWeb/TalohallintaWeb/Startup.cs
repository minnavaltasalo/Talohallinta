using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TalohallintaWeb.Startup))]
namespace TalohallintaWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
